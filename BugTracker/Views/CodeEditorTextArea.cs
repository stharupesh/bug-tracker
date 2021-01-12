using System.Drawing;
using System.Windows.Forms;
using ScintillaNET;
using BugTracker.View.Utils;
using BugTracker.Views.Utils;
using System;
using System.IO;

namespace BugTracker.Views
{
    public partial class CodeEditorTextArea : Scintilla
    {

        // Numbers, Bookmarks, Code Folding

        private Form formRef;

        private TextBox searchBoxRef;

        private Panel searchBoxPanelRef;

        private const int BACK_COLOR = 0x2A211C;

        private const int FORE_COLOR = 0xB7B7B7;

        private const int NUMBER_MARGIN = 1;

        private const int BOOKMARK_MARGIN = 2;
        private const int BOOKMARK_MARKER = 2;

        private const int FOLDING_MARGIN = 3;
        private const bool CODEFOLDING_CIRCULAR = true;

        public CodeEditorTextArea(Form form, TextBox searchBox, Panel searchBoxPanel)
        {
            this.BorderStyle = BorderStyle.None;

            this.formRef = form;

            this.searchBoxRef = searchBox;

            this.searchBoxPanelRef = searchBoxPanel;

            this.Dock = System.Windows.Forms.DockStyle.Fill;

            this.WrapMode = WrapMode.None;
            this.IndentationGuides = IndentView.LookBoth;

            this.InitColors();
            this.InitSyntaxColoring();

            this.InitNumberMargin();

            this.InitBookmarkMargin();

            this.InitCodeFolding();

            this.InitHotkeys();

            this.InitDragDropFile();
        }

        private void InitColors()
        {
            this.SetSelectionBackColor(true, IntToColor(0x114D9C));
            this.CaretForeColor = Color.White;
        }

        private void InitSyntaxColoring()
        {
            this.StyleResetDefault();
            this.Styles[Style.Default].Font = "Consolas";
            this.Styles[Style.Default].Size = 10;
            this.Styles[Style.Default].BackColor = IntToColor(0x212121);
            this.Styles[Style.Default].ForeColor = IntToColor(0xFFFFFF);
            this.StyleClearAll();

            this.Styles[Style.Cpp.Identifier].ForeColor = IntToColor(0xD0DAE2);
            this.Styles[Style.Cpp.Comment].ForeColor = IntToColor(0xBD758B);
            this.Styles[Style.Cpp.CommentLine].ForeColor = IntToColor(0x40BF57);
            this.Styles[Style.Cpp.CommentDoc].ForeColor = IntToColor(0x2FAE35);
            this.Styles[Style.Cpp.Number].ForeColor = IntToColor(0xFFFF00);
            this.Styles[Style.Cpp.String].ForeColor = IntToColor(0xFFFF00);
            this.Styles[Style.Cpp.Character].ForeColor = IntToColor(0xE95454);
            this.Styles[Style.Cpp.Preprocessor].ForeColor = IntToColor(0x8AAFEE);
            this.Styles[Style.Cpp.Operator].ForeColor = IntToColor(0xE0E0E0);
            this.Styles[Style.Cpp.Regex].ForeColor = IntToColor(0xff00ff);
            this.Styles[Style.Cpp.CommentLineDoc].ForeColor = IntToColor(0x77A7DB);
            this.Styles[Style.Cpp.Word].ForeColor = IntToColor(0x48A8EE);
            this.Styles[Style.Cpp.Word2].ForeColor = IntToColor(0xF98906);
            this.Styles[Style.Cpp.CommentDocKeyword].ForeColor = IntToColor(0xB3D991);
            this.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = IntToColor(0xFF0000);
            this.Styles[Style.Cpp.GlobalClass].ForeColor = IntToColor(0x48A8EE);

            this.Lexer = Lexer.Cpp;
        }

        private void InitHotkeys()
        {

            // register the hotkeys with the form
            HotKeyManager.AddHotKey(formRef, OpenSearch, Keys.F, true);
            HotKeyManager.AddHotKey(formRef, Uppercase, Keys.U, true);
            HotKeyManager.AddHotKey(formRef, Lowercase, Keys.L, true);
            HotKeyManager.AddHotKey(formRef, this.ZoomIn, Keys.Oemplus, true);
            HotKeyManager.AddHotKey(formRef, ZoomOut, Keys.OemMinus, true);
            HotKeyManager.AddHotKey(formRef, ZoomDefault, Keys.D0, true);
            HotKeyManager.AddHotKey(formRef, CloseSearch, Keys.Escape);

            // remove conflicting hotkeys from scintilla
            this.ClearCmdKey(Keys.Control | Keys.F);
            this.ClearCmdKey(Keys.Control | Keys.R);
            this.ClearCmdKey(Keys.Control | Keys.H);
            this.ClearCmdKey(Keys.Control | Keys.L);
            this.ClearCmdKey(Keys.Control | Keys.U);
            this.ClearCmdKey(Keys.Control | Keys.S);
        }


        #region Quick Search Bar

        bool SearchIsOpen = false;

        private void OpenSearch()
        {

            SearchManager.SearchBox = this.searchBoxRef;
            SearchManager.TextArea = this;

            if (!SearchIsOpen)
            {
                SearchIsOpen = true;
                InvokeIfNeeded(delegate () {
                    searchBoxPanelRef.Visible = true;
                    searchBoxRef.Text = SearchManager.LastSearch;
                    searchBoxRef.Focus();
                    searchBoxRef.SelectAll();
                });
            }
            else
            {
                InvokeIfNeeded(delegate () {
                    searchBoxRef.Focus();
                    searchBoxRef.SelectAll();
                });
            }
        }
        private void CloseSearch()
        {
            if (SearchIsOpen)
            {
                SearchIsOpen = false;
                InvokeIfNeeded(delegate () {
                    searchBoxPanelRef.Visible = false;
                    //CurBrowser.GetBrowser().StopFinding(true);
                });
            }
        }

        #endregion

        public void InvokeIfNeeded(Action action)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(action);
            }
            else
            {
                action.Invoke();
            }
        }

        public void clearSearch()
        {
            this.CloseSearch();
        }

        public void previousSearch()
        {
            SearchManager.Find(false, false);
        }

        public void nextSearch()
        {
            SearchManager.Find(true, false);
        }

        public void searchChanged()
        {
            SearchManager.Find(true, true);
        }

        public void searchKeyDown(KeyEventArgs e)
        {
            if (HotKeyManager.IsHotkey(e, Keys.Enter))
            {
                SearchManager.Find(true, false);
            }
            if (HotKeyManager.IsHotkey(e, Keys.Enter, true) || HotKeyManager.IsHotkey(e, Keys.Enter, false, true))
            {
                SearchManager.Find(false, false);
            }
        }

        private void Lowercase()
        {

            // save the selection
            int start = this.SelectionStart;
            int end = this.SelectionEnd;

            // modify the selected text
            this.ReplaceSelection(this.GetTextRange(start, end - start).ToLower());

            // preserve the original selection
            this.SetSelection(start, end);
        }

        private void Uppercase()
        {
            // save the selection
            int start = this.SelectionStart;
            int end = this.SelectionEnd;

            // modify the selected text
            this.ReplaceSelection(this.GetTextRange(start, end - start).ToUpper());

            // preserve the original selection
            this.SetSelection(start, end);
        }

        private new void ZoomIn()
        {
            this.ZoomIn();
        }

        private new void ZoomOut()
        {
            this.ZoomOut();
        }

        private void ZoomDefault()
        {
            this.Zoom = 0;
        }

        public CodeEditorTextArea setLanguage(string lang)
        {
            switch (lang)
            {
                case "C":
                    {
                        this.SetKeywords(0, "if else switch case default break goto return for while do continue typedef sizeof NULL");
                        this.SetKeywords(1, "void struct union enum char short int long double float signed unsigned const static extern auto register volatile");
                    }
                    break;

                case "C#":
                    {
                        this.SetKeywords(0, "class extends implements import interface new case do while else if for in switch throw get set function var try catch finally while with default break continue delete return each const namespace package include use is as instanceof typeof author copy default deprecated eventType example exampleText exception haxe inheritDoc internal link mtasc mxmlc param private return see serial serialData serialField since throws usage version langversion playerversion productversion dynamic private public partial static intrinsic internal native override protected AS3 final super this arguments null Infinity NaN undefined true false abstract as base bool break by byte case catch char checked class const continue decimal default delegate do double descending explicit event extern else enum false finally fixed float for foreach from goto group if implicit in int interface internal into is lock long new null namespace object operator out override orderby params private protected public readonly ref return switch struct sbyte sealed short sizeof stackalloc static string select this throw true try typeof uint ulong unchecked unsafe ushort using var virtual volatile void while where yield");
                        this.SetKeywords(1, "void Null ArgumentError arguments Array Boolean Class Date DefinitionError Error EvalError Function int Math Namespace Number Object RangeError ReferenceError RegExp SecurityError String SyntaxError TypeError uint XML XMLList Boolean Byte Char DateTime Decimal Double Int16 Int32 Int64 IntPtr SByte Single UInt16 UInt32 UInt64 UIntPtr Void Path File System Windows Forms ScintillaNET");
                    }
                    break;

                case "C++":
                    {
                        this.SetKeywords(0, "alignof and and_eq bitand bitor break case catch compl const_cast continue default delete do dynamic_cast else false for goto if namespace new not not_eq nullptr operator or or_eq reinterpret_cast return sizeof static_assert static_cast switch this throw true try typedef typeid using while xor xor_eq NULL");
                        this.SetKeywords(1, "alignas asm auto bool char char16_t char32_t class const constexpr decltype double enum explicit export extern final float friend inline int long mutable noexcept override private protected public register short signed static struct template thread_local typename union unsigned virtual void volatile wchar_t");
                    }
                    break;

                case "Java":
                    {
                        this.SetKeywords(0, "instanceof assert if else switch case default break goto return for while do continue new throw throws try catch finally this super extends implements import true false null");
                        this.SetKeywords(1, "package transient strictfp void char short int long double float const static volatile byte boolean class interface native private protected public final abstract synchronized enum");
                    }
                    break;

                case "Javascript":
                    {
                        this.SetKeywords(0, "abstract boolean break byte case catch char class const continue debugger default delete do double else enum export extends final finally float for function goto if implements import in instanceof int interface long native new package private protected public return short static super switch synchronized this throw throws transient try typeof var void volatile while with true false prototype");
                    }
                    break;

                case "PHP":
                    {
                        this.SetKeywords(0, "filesize filemtime ksort sort count shell_exec disk_free_space disk_total_space file_exists strip_tags htmlentities stripslashes mysql_real_escape_string session_start error_reporting define srt_replace pathinfo date time version_compare sha1 sha1_file md5 md5_file ignore_user_abort and or xor __dir__ __method__ __namespace__ __file__ __line__ array as break case cfunction class const continue declare default die do echo else elseif empty enddeclare endfor endforeach endif endswitch endwhile eval exit extends for foreach function global if include include_once isset list new old_function print require require_once return static switch unset use var while __function__ __class__ php_version php_os default_include_path pear_install_dir pear_extension_dir php_extension_dir php_bindir php_libdir php_datadir php_sysconfdir php_localstatedir php_config_file_path php_output_handler_start php_output_handler_cont php_output_handler_end e_error e_warning e_parse e_notice e_core_error e_core_warning e_compile_error e_compile_warning e_user_error e_user_warning e_user_notice e_all true false bool boolean int integer float double real string array object resource null class extends parent stdclass directory __sleep __wakeup interface implements abstract public protected private printf print_r php_major_version php_minor_version php_release_version php_version_id php_extra_version php_zts php_debug php_maxpathlen php_sapi php_eol php_int_max php_int_size php_prefix php_mandir php_config_file_scan_dir php_shlib_suffix php_windows_version_major php_windows_version_minor php_windows_version_build php_windows_version_platform php_windows_version_sp_major php_windows_version_sp_minor php_windows_version_suitemask php_windows_version_producttype php_windows_nt_domain_controller php_windows_nt_server php_windows_nt_workstation e_deprecated e_user_deprecated e_strict __compiler_halt_offset__ extr_overwrite extr_skip extr_prefix_same extr_prefix_all extr_prefix_invalid extr_prefix_if_exists extr_if_exists sort_asc sort_desc sort_regular sort_numeric sort_string case_lower case_upper count_normal count_recursive assert_active assert_callback assert_bail assert_warning assert_quiet_eval connection_aborted connection_normal connection_timeout ini_user ini_perdir ini_system ini_all m_e m_log2e m_log10e m_ln2 m_ln10 m_pi m_pi_2 m_pi_4 m_1_pi m_2_pi m_2_sqrtpi m_sqrt2 m_sqrt1_2 crypt_salt_length crypt_std_des crypt_ext_des crypt_md5 crypt_blowfish directory_separator seek_set seek_cur seek_end lock_sh lock_ex lock_un lock_nb html_specialchars html_entities ent_compat ent_quotes ent_noquotes info_general info_credits info_configuration info_modules info_environment info_variables info_license info_all credits_group credits_general credits_sapi credits_modules credits_docs credits_fullpage credits_qa credits_all str_pad_left str_pad_right str_pad_both pathinfo_dirname pathinfo_basename pathinfo_extension path_separator char_max lc_ctype lc_numeric lc_time lc_collate lc_monetary lc_all lc_messages abday_1 abday_2 abday_3 abday_4 abday_5 abday_6 abday_7 day_1 day_2 day_3 day_4 day_5 day_6 day_7 abmon_1 abmon_2 abmon_3 abmon_4 abmon_5 abmon_6 abmon_7 abmon_8 abmon_9 abmon_10 abmon_11 abmon_12 mon_1 mon_2 mon_3 mon_4 mon_5 mon_6 mon_7 mon_8 mon_9 mon_10 mon_11 mon_12 am_str pm_str d_t_fmt d_fmt t_fmt t_fmt_ampm era era_year era_d_t_fmt era_d_fmt era_t_fmt alt_digits int_curr_symbol currency_symbol crncystr mon_decimal_point mon_thousands_sep mon_grouping positive_sign negative_sign int_frac_digits frac_digits p_cs_precedes p_sep_by_space n_cs_precedes n_sep_by_space p_sign_posn n_sign_posn decimal_point radixchar thousands_sep thousep grouping yesexpr noexpr yesstr nostr codeset log_emerg log_alert log_crit log_err log_warning log_notice log_info log_debug log_kern log_user log_mail log_daemon log_auth log_syslog log_lpr log_news log_uucp log_cron log_authpriv log_local0 log_local1 log_local2 log_local3 log_local4 log_local5 log_local6 log_local7 log_pid log_cons log_odelay log_ndelay log_nowait log_perror msql_connect msql_close msql msql_create_db msql_createdb msql_drop_db msql_drop_db msql_select_db msql_select_db msql_pconnect msql msql_create_db msql_createdb msql_drop_db msql_drop_db msql_select_db msql_select_db msql_db_query msql_list_dbs msql_list_fields msql_list_tables msql_query msql msql_affected_rows msql_data_seek msql_dbname msql_fetch_array msql_fetch_field msql_fetch_object msql_fetch_row msql_field_seek msql_field_table msql_field_flags msql_field_len msql_field_name msql_field_type msql_num_fields msql_num_rows msql_numfields msql_numrows msql_result mssql_connect mssql_query mssql_select_db mssql_close mssql_pconnect mssql_query mssql_select_db mssql_query mssql_data_seek mssql_fetch_array mssql_fetch_field mssql_fetch_object mssql_fetch_row mssql_field_length mssql_field_name mssql_field_seek mssql_field_type mssql_num_fields mssql_num_rows mssql_result mssql_free_result mysql_connect mysql_affected_rows mysql_change_user mysql_create_db mysql_data_seek mysql_db_name mysql_db_query mysql_drop_db mysql_errno mysql_error mysql_insert_id mysql_list_dbs mysql_list_fields mysql_list_tables mysql_query mysql_result mysql_select_db mysql_tablename mysql_get_host_info mysql_get_proto_info mysql_get_server_info mysql_close mysql_pconnect mysql_affected_rows mysql_change_user mysql_create_db mysql_data_seek mysql_db_name mysql_db_query mysql_drop_db mysql_errno mysql_error mysql_insert_id mysql_list_dbs mysql_list_fields mysql_list_tables mysql_query mysql_result mysql_select_db mysql_tablename mysql_get_host_info mysql_get_proto_info mysql_get_server_info mysql_db_query mysql_list_dbs mysql_list_fields mysql_list_processes mysql_list_tables mysql_query mysql_unbuffered_query mysql_data_seek mysql_db_name mysql_fetch_array mysql_fetch_assoc mysql_fetch_field mysql_fetch_lengths mysql_fetch_object mysql_fetch_row mysql_fetch_row mysql_field_flags mysql_field_name mysql_field_len mysql_field_seek mysql_field_table mysql_field_type mysql_num_fields mysql_num_rows mysql_result mysql_tablename mysql_free_result ocilogon ociplogon ocinlogon ocicommit ociserverversion ocinewcursor ociparse ocierror ocilogoff ocinewdescriptor ocirollback ocinewdescriptor ocirowcount ocidefinebyname ocibindbyname ociexecute ocinumcols ociresult ocifetch ocifetchinto ocifetchstatement ocicolumnisnull ocicolumnname ocicolumnsize ocicolumntype ocistatementtype ocierror ocifreestatement odbc_connect odbc_autocommit odbc_commit odbc_error odbc_errormsg odbc_exec odbc_tables odbc_tableprivileges odbc_do odbc_prepare odbc_columns odbc_columnprivileges odbc_procedurecolumns odbc_specialcolumns odbc_rollback odbc_setoption odbc_gettypeinfo odbc_primarykeys odbc_foreignkeys odbc_procedures odbc_statistics odbc_close odbc_pconnect odbc_autocommit odbc_commit odbc_error odbc_errormsg odbc_exec odbc_tables odbc_tableprivileges odbc_do odbc_prepare odbc_columns odbc_columnprivileges odbc_procedurecolumns odbc_specialcolumns odbc_rollback odbc_setoption odbc_gettypeinfo odbc_primarykeys odbc_foreignkeys odbc_procedures odbc_statistics odbc_prepare odbc_binmode odbc_cursor odbc_execute odbc_fetch_into odbc_fetch_row odbc_field_name odbc_field_num odbc_field_type odbc_field_len odbc_field_precision odbc_field_scale odbc_longreadlen odbc_num_fields odbc_num_rows odbc_result odbc_result_all odbc_setoption odbc_free_result openssl_get_privatekey openssl_get_publickey openssl_sign openssl_seal openssl_open openssl_verify openssl_free_key xml_parser_create xml_parser_create_ns xml_set_object xml_set_element_handler xml_set_character_data_handler xml_set_processing_instruction_handler xml_set_default_handler xml_set_unparsed_entity_decl_handler xml_set_notation_decl_handler xml_set_external_entity_ref_handler xml_parse xml_get_error_code xml_error_string xml_get_current_line_number xml_get_current_column_number xml_get_current_byte_index xml_parse_into_struct xml_parser_set_option xml_parser_get_option xml_parser_free gzopen gzeof gzgetc gzgets gzgetss gzpassthru gzputs gzread gzrewind gzseek gztell gzwrite gzclose bzopen bzerrno bzerror bzerrstr bzflush bzread bzwrite bzclose com_load com_invoke com_propget com_get com_propput com_set com_propput imagecreate imagecreatefromgd imagecreatefromgd2 imagecreatefromgd2part imagecreatefromgif imagecreatefromjpeg imagecreatefrompng imagecreatefromwbmp imagecreatefromstring imagecreatefromxbm imagecreatefromxpm imagecreatetruecolor imagerotate imagearc imagechar imagecharup imagecolorallocate imagecolorat imagecolorclosest imagecolorexact imagecolorresolve imagegammacorrect imagegammacorrect imagecolorset imagecolorsforindex imagecolorstotal imagecolortransparent imagecopy imagecopyresized imagedashedline imagefill imagefilledpolygon imagefilledrectangle imagefilltoborder imagegif imagepng imagejpeg imagewbmp imageinterlace imageline imagepolygon imagepstext imagerectangle imagerotate imagesetpixel imagestring imagestringup imagesx imagesy imagettftext imagefilledarc imageellipse imagefilledellipse imagecolorclosestalpha imagecolorexactalpha imagecolorresolvealpha imagecopymerge imagecopymergegray imagecopyresampled imagetruecolortopalette imagesetbrush imagesettile imagesetthickness image2wbmp imagealphablending imageantialias imagecolorallocatealpha imagecolorclosesthwb imagecolordeallocate imagecolormatch imagefilter imagefttext imagegd imagegd2 imageistruecolor imagelayereffect imagepalettecopy imagesavealpha imagesetstyle imagexbm imagedestroy imageloadfont imagechar imagecharup imagefontheight imagepsloadfont imagepstext imagepsslantfont imagepsextendfont imagepsencodefont imagepsbbox imagepsfreefont curl_copy_handle curl_init curl_copy_handle curl_errno curl_error curl_exec curl_getinfo curl_setopt curl_close dba_open dba_delete dba_exists dba_fetch dba_firstkey dba_insert dba_nextkey dba_optimize dba_replace dba_sync dba_close dba_popen dba_delete dba_exists dba_fetch dba_firstkey dba_insert dba_nextkey dba_optimize dba_replace dba_sync strstr strtoupper strtolower strpos explode implode closedir getdir floatval rtrim fwrite extension_loaded final catch clone goto instanceof namespace throw try trigger_error ftp_connect ftp_ssl_connect ftp_close ftp_login ftp_pwd ftp_cdup ftp_chdir ftp_mkdir ftp_rmdir ftp_nlist ftp_rawlist ftp_systype ftp_pasv ftp_get ftp_fget ftp_put ftp_fput ftp_size ftp_mdtm ftp_rename ftp_delete ftp_site ftp_alloc ftp_chmod ftp_exec ftp_get_option ftp_nb_continue ftp_nb_fget ftp_nb_fput ftp_nb_get ftp_nb_put ftp_raw ftp_set_option imap_open imap_close imap_append imap_body imap_check imap_createmailbox imap_delete imap_deletemailbox imap_expunge imap_fetchbody imap_fetchstructure imap_headerinfo imap_header imap_headers imap_listmailbox imap_getmailboxes imap_get_quota imap_status imap_listsubscribed imap_set_quota imap_set_quota imap_getsubscribed imap_mail_copy imap_mail_move imap_num_msg imap_num_recent imap_ping imap_renamemailbox imap_reopen imap_subscribe imap_undelete imap_unsubscribe imap_scanmailbox imap_mailboxmsginfo imap_fetchheader imap_uid imap_msgno imap_search imap_fetch_overview array_change_key_case array_chunk array_combine array_count_values array_diff array_diff_assoc array_diff_key array_diff_uassoc array_diff_ukey array_fill array_fill_keys array_filter array_flip array_intersect array_intersect_assoc array_intersect_key array_intersect_uassoc array_intersect_ukey array_key_exists array_keys array_map array_merge array_merge_recursive array_multisort array_pad array_pop array_product array_push array_rand array_reduce array_replace array_replace_recursive array_reverse array_search array_shift array_slice array_splice array_sum array_udiff array_udiff_assoc array_udiff_uassoc array_uintersect array_uintersect_assoc array_uintersect_uassoc array_unique array_unshift array_values array_walk array_walk_recursive arrayaccess arrayiterator arrayobject fclose flock floor flush fmod fnmatch fopen fpassthru fprintf fputcsv fputs fread fscanf fseek fsockopen fstat ftell __construct __destruct");
                    }
                    break;

                case "Python":
                    {
                        this.SetKeywords(0, "and as assert break class continue def del elif else except exec False finally for from global if import in is lambda None not or pass print raise return triple True try while with yield");
                    }
                    break;
            }

            return this;
        }

        private void InitBookmarkMargin()
        {
            //TextArea.SetFoldMarginColor(true, IntToColor(BACK_COLOR));

            var margin = this.Margins[BOOKMARK_MARGIN];
            margin.Width = 5;
            margin.Sensitive = true;
            margin.Type = MarginType.Symbol;
            margin.Mask = (1 << BOOKMARK_MARKER);
            //margin.Cursor = MarginCursor.Arrow;

            var marker = this.Markers[BOOKMARK_MARKER];
            marker.Symbol = MarkerSymbol.Circle;
            marker.SetBackColor(IntToColor(0xFF003B));
            marker.SetForeColor(IntToColor(0x000000));
            marker.SetAlpha(100);
        }

        private void InitNumberMargin()
        {
            this.Styles[Style.LineNumber].BackColor = IntToColor(BACK_COLOR);
            this.Styles[Style.LineNumber].ForeColor = IntToColor(FORE_COLOR);
            this.Styles[Style.IndentGuide].ForeColor = IntToColor(FORE_COLOR);
            this.Styles[Style.IndentGuide].BackColor = IntToColor(BACK_COLOR);

            var nums = this.Margins[NUMBER_MARGIN];
            nums.Width = 30;
            nums.Type = MarginType.Number;
            nums.Sensitive = true;
            nums.Mask = 0;

            this.MarginClick += CodeEditorTextArea_MarginClick;
        }


        public void InitDragDropFile()
        {

            this.AllowDrop = true;
            this.DragEnter += delegate (object sender, DragEventArgs e) {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                    e.Effect = DragDropEffects.Copy;
                else
                    e.Effect = DragDropEffects.None;
            };
            this.DragDrop += delegate (object sender, DragEventArgs e) {

                // get file drop
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {

                    Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
                    if (a != null)
                    {

                        string path = a.GetValue(0).ToString();

                        LoadDataFromFile(path);

                    }
                }
            };

        }

        private void LoadDataFromFile(string path)
        {
            if (File.Exists(path))
            {
                this.Text = File.ReadAllText(path);
            }
        }

        private void InitCodeFolding()
        {

            this.SetFoldMarginColor(true, IntToColor(BACK_COLOR));
            this.SetFoldMarginHighlightColor(true, IntToColor(BACK_COLOR));

            // Enable code folding
            this.SetProperty("fold", "1");
            this.SetProperty("fold.compact", "1");

            // Configure a margin to display folding symbols
            this.Margins[FOLDING_MARGIN].Type = MarginType.Symbol;
            this.Margins[FOLDING_MARGIN].Mask = Marker.MaskFolders;
            this.Margins[FOLDING_MARGIN].Sensitive = true;
            this.Margins[FOLDING_MARGIN].Width = 20;

            // Set colors for all folding markers
            for (int i = 25; i <= 31; i++)
            {
                this.Markers[i].SetForeColor(IntToColor(BACK_COLOR)); // styles for [+] and [-]
                this.Markers[i].SetBackColor(IntToColor(FORE_COLOR)); // styles for [+] and [-]
            }

            // Configure folding markers with respective symbols
            this.Markers[Marker.Folder].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CirclePlus : MarkerSymbol.BoxPlus;
            this.Markers[Marker.FolderOpen].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CircleMinus : MarkerSymbol.BoxMinus;
            this.Markers[Marker.FolderEnd].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CirclePlusConnected : MarkerSymbol.BoxPlusConnected;
            this.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            this.Markers[Marker.FolderOpenMid].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CircleMinusConnected : MarkerSymbol.BoxMinusConnected;
            this.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            this.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            this.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);

        }

        public static Color IntToColor(int rgb)
        {
            return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
        }
        private void CodeEditorTextArea_MarginClick(object sender, MarginClickEventArgs e)
        {
            if (e.Margin == BOOKMARK_MARGIN)
            {
                // Do we have a marker for this line?
                const uint mask = (1 << BOOKMARK_MARKER);
                var line = this.Lines[this.LineFromPosition(e.Position)];
                if ((line.MarkerGet() & mask) > 0)
                {
                    // Remove existing bookmark
                    line.MarkerDelete(BOOKMARK_MARKER);
                }
                else
                {
                    // Add bookmark
                    line.MarkerAdd(BOOKMARK_MARKER);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
