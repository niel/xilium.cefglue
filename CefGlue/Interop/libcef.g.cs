﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Runtime.InteropServices;
    using System.Diagnostics.CodeAnalysis;
    
    internal static unsafe partial class libcef
    {
        // CefExecuteProcess
        [DllImport(libcef.DllName, EntryPoint = "cef_execute_process", CallingConvention = libcef.CEF_CALL)]
        public static extern int execute_process(cef_main_args_t* args, cef_app_t* application, void* windows_sandbox_info);
        
        // CefInitialize
        [DllImport(libcef.DllName, EntryPoint = "cef_initialize", CallingConvention = libcef.CEF_CALL)]
        public static extern int initialize(cef_main_args_t* args, cef_settings_t* settings, cef_app_t* application, void* windows_sandbox_info);
        
        // CefShutdown
        [DllImport(libcef.DllName, EntryPoint = "cef_shutdown", CallingConvention = libcef.CEF_CALL)]
        public static extern void shutdown();
        
        // CefDoMessageLoopWork
        [DllImport(libcef.DllName, EntryPoint = "cef_do_message_loop_work", CallingConvention = libcef.CEF_CALL)]
        public static extern void do_message_loop_work();
        
        // CefRunMessageLoop
        [DllImport(libcef.DllName, EntryPoint = "cef_run_message_loop", CallingConvention = libcef.CEF_CALL)]
        public static extern void run_message_loop();
        
        // CefQuitMessageLoop
        [DllImport(libcef.DllName, EntryPoint = "cef_quit_message_loop", CallingConvention = libcef.CEF_CALL)]
        public static extern void quit_message_loop();
        
        // CefSetOSModalLoop
        [DllImport(libcef.DllName, EntryPoint = "cef_set_osmodal_loop", CallingConvention = libcef.CEF_CALL)]
        public static extern void set_osmodal_loop(int osModalLoop);
        
        // CefEnableHighDPISupport
        [DllImport(libcef.DllName, EntryPoint = "cef_enable_highdpi_support", CallingConvention = libcef.CEF_CALL)]
        public static extern void enable_highdpi_support();
        
        // CefCrashReportingEnabled
        [DllImport(libcef.DllName, EntryPoint = "cef_crash_reporting_enabled", CallingConvention = libcef.CEF_CALL)]
        public static extern int crash_reporting_enabled();
        
        // CefSetCrashKeyValue
        [DllImport(libcef.DllName, EntryPoint = "cef_set_crash_key_value", CallingConvention = libcef.CEF_CALL)]
        public static extern void set_crash_key_value(cef_string_t* key, cef_string_t* value);
        
        // CefCreateDirectory
        [DllImport(libcef.DllName, EntryPoint = "cef_create_directory", CallingConvention = libcef.CEF_CALL)]
        public static extern int create_directory(cef_string_t* full_path);
        
        // CefGetTempDirectory
        [DllImport(libcef.DllName, EntryPoint = "cef_get_temp_directory", CallingConvention = libcef.CEF_CALL)]
        public static extern int get_temp_directory(cef_string_t* temp_dir);
        
        // CefCreateNewTempDirectory
        [DllImport(libcef.DllName, EntryPoint = "cef_create_new_temp_directory", CallingConvention = libcef.CEF_CALL)]
        public static extern int create_new_temp_directory(cef_string_t* prefix, cef_string_t* new_temp_path);
        
        // CefCreateTempDirectoryInDirectory
        [DllImport(libcef.DllName, EntryPoint = "cef_create_temp_directory_in_directory", CallingConvention = libcef.CEF_CALL)]
        public static extern int create_temp_directory_in_directory(cef_string_t* base_dir, cef_string_t* prefix, cef_string_t* new_dir);
        
        // CefDirectoryExists
        [DllImport(libcef.DllName, EntryPoint = "cef_directory_exists", CallingConvention = libcef.CEF_CALL)]
        public static extern int directory_exists(cef_string_t* path);
        
        // CefDeleteFile
        [DllImport(libcef.DllName, EntryPoint = "cef_delete_file", CallingConvention = libcef.CEF_CALL)]
        public static extern int delete_file(cef_string_t* path, int recursive);
        
        // CefZipDirectory
        [DllImport(libcef.DllName, EntryPoint = "cef_zip_directory", CallingConvention = libcef.CEF_CALL)]
        public static extern int zip_directory(cef_string_t* src_dir, cef_string_t* dest_file, int include_hidden_files);
        
        // CefGetGeolocation
        [DllImport(libcef.DllName, EntryPoint = "cef_get_geolocation", CallingConvention = libcef.CEF_CALL)]
        public static extern int get_geolocation(cef_get_geolocation_callback_t* callback);
        
        // CefAddCrossOriginWhitelistEntry
        [DllImport(libcef.DllName, EntryPoint = "cef_add_cross_origin_whitelist_entry", CallingConvention = libcef.CEF_CALL)]
        public static extern int add_cross_origin_whitelist_entry(cef_string_t* source_origin, cef_string_t* target_protocol, cef_string_t* target_domain, int allow_target_subdomains);
        
        // CefRemoveCrossOriginWhitelistEntry
        [DllImport(libcef.DllName, EntryPoint = "cef_remove_cross_origin_whitelist_entry", CallingConvention = libcef.CEF_CALL)]
        public static extern int remove_cross_origin_whitelist_entry(cef_string_t* source_origin, cef_string_t* target_protocol, cef_string_t* target_domain, int allow_target_subdomains);
        
        // CefClearCrossOriginWhitelist
        [DllImport(libcef.DllName, EntryPoint = "cef_clear_cross_origin_whitelist", CallingConvention = libcef.CEF_CALL)]
        public static extern int clear_cross_origin_whitelist();
        
        // CefParseURL
        [DllImport(libcef.DllName, EntryPoint = "cef_parse_url", CallingConvention = libcef.CEF_CALL)]
        public static extern int parse_url(cef_string_t* url, cef_urlparts_t* parts);
        
        // CefCreateURL
        [DllImport(libcef.DllName, EntryPoint = "cef_create_url", CallingConvention = libcef.CEF_CALL)]
        public static extern int create_url(cef_urlparts_t* parts, cef_string_t* url);
        
        // CefFormatUrlForSecurityDisplay
        [DllImport(libcef.DllName, EntryPoint = "cef_format_url_for_security_display", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_string_userfree* format_url_for_security_display(cef_string_t* origin_url);
        
        // CefGetMimeType
        [DllImport(libcef.DllName, EntryPoint = "cef_get_mime_type", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_string_userfree* get_mime_type(cef_string_t* extension);
        
        // CefGetExtensionsForMimeType
        [DllImport(libcef.DllName, EntryPoint = "cef_get_extensions_for_mime_type", CallingConvention = libcef.CEF_CALL)]
        public static extern void get_extensions_for_mime_type(cef_string_t* mime_type, cef_string_list* extensions);
        
        // CefBase64Encode
        [DllImport(libcef.DllName, EntryPoint = "cef_base64encode", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_string_userfree* base64encode(void* data, UIntPtr data_size);
        
        // CefBase64Decode
        [DllImport(libcef.DllName, EntryPoint = "cef_base64decode", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_binary_value_t* base64decode(cef_string_t* data);
        
        // CefURIEncode
        [DllImport(libcef.DllName, EntryPoint = "cef_uriencode", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_string_userfree* uriencode(cef_string_t* text, int use_plus);
        
        // CefURIDecode
        [DllImport(libcef.DllName, EntryPoint = "cef_uridecode", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_string_userfree* uridecode(cef_string_t* text, int convert_to_utf8, CefUriUnescapeRules unescape_rule);
        
        // CefParseJSON
        [DllImport(libcef.DllName, EntryPoint = "cef_parse_json", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_value_t* parse_json(cef_string_t* json_string, CefJsonParserOptions options);
        
        // CefParseJSONAndReturnError
        [DllImport(libcef.DllName, EntryPoint = "cef_parse_jsonand_return_error", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_value_t* parse_jsonand_return_error(cef_string_t* json_string, CefJsonParserOptions options, CefJsonParserError* error_code_out, cef_string_t* error_msg_out);
        
        // CefWriteJSON
        [DllImport(libcef.DllName, EntryPoint = "cef_write_json", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_string_userfree* write_json(cef_value_t* node, CefJsonWriterOptions options);
        
        // CefGetPath
        [DllImport(libcef.DllName, EntryPoint = "cef_get_path", CallingConvention = libcef.CEF_CALL)]
        public static extern int get_path(CefPathKey key, cef_string_t* path);
        
        // CefLaunchProcess
        [DllImport(libcef.DllName, EntryPoint = "cef_launch_process", CallingConvention = libcef.CEF_CALL)]
        public static extern int launch_process(cef_command_line_t* command_line);
        
        // CefRegisterSchemeHandlerFactory
        [DllImport(libcef.DllName, EntryPoint = "cef_register_scheme_handler_factory", CallingConvention = libcef.CEF_CALL)]
        public static extern int register_scheme_handler_factory(cef_string_t* scheme_name, cef_string_t* domain_name, cef_scheme_handler_factory_t* factory);
        
        // CefClearSchemeHandlerFactories
        [DllImport(libcef.DllName, EntryPoint = "cef_clear_scheme_handler_factories", CallingConvention = libcef.CEF_CALL)]
        public static extern int clear_scheme_handler_factories();
        
        // CefIsCertStatusError
        [DllImport(libcef.DllName, EntryPoint = "cef_is_cert_status_error", CallingConvention = libcef.CEF_CALL)]
        public static extern int is_cert_status_error(CefCertStatus status);
        
        // CefIsCertStatusMinorError
        [DllImport(libcef.DllName, EntryPoint = "cef_is_cert_status_minor_error", CallingConvention = libcef.CEF_CALL)]
        public static extern int is_cert_status_minor_error(CefCertStatus status);
        
        // CefCurrentlyOn
        [DllImport(libcef.DllName, EntryPoint = "cef_currently_on", CallingConvention = libcef.CEF_CALL)]
        public static extern int currently_on(CefThreadId threadId);
        
        // CefPostTask
        [DllImport(libcef.DllName, EntryPoint = "cef_post_task", CallingConvention = libcef.CEF_CALL)]
        public static extern int post_task(CefThreadId threadId, cef_task_t* task);
        
        // CefPostDelayedTask
        [DllImport(libcef.DllName, EntryPoint = "cef_post_delayed_task", CallingConvention = libcef.CEF_CALL)]
        public static extern int post_delayed_task(CefThreadId threadId, cef_task_t* task, long delay_ms);
        
        // CefBeginTracing
        [DllImport(libcef.DllName, EntryPoint = "cef_begin_tracing", CallingConvention = libcef.CEF_CALL)]
        public static extern int begin_tracing(cef_string_t* categories, cef_completion_callback_t* callback);
        
        // CefEndTracing
        [DllImport(libcef.DllName, EntryPoint = "cef_end_tracing", CallingConvention = libcef.CEF_CALL)]
        public static extern int end_tracing(cef_string_t* tracing_file, cef_end_tracing_callback_t* callback);
        
        // CefNowFromSystemTraceTime
        [DllImport(libcef.DllName, EntryPoint = "cef_now_from_system_trace_time", CallingConvention = libcef.CEF_CALL)]
        public static extern long now_from_system_trace_time();
        
        // CefRegisterExtension
        [DllImport(libcef.DllName, EntryPoint = "cef_register_extension", CallingConvention = libcef.CEF_CALL)]
        public static extern int register_extension(cef_string_t* extension_name, cef_string_t* javascript_code, cef_v8handler_t* handler);
        
        // CefVisitWebPluginInfo
        [DllImport(libcef.DllName, EntryPoint = "cef_visit_web_plugin_info", CallingConvention = libcef.CEF_CALL)]
        public static extern void visit_web_plugin_info(cef_web_plugin_info_visitor_t* visitor);
        
        // CefRefreshWebPlugins
        [DllImport(libcef.DllName, EntryPoint = "cef_refresh_web_plugins", CallingConvention = libcef.CEF_CALL)]
        public static extern void refresh_web_plugins();
        
        // CefUnregisterInternalWebPlugin
        [DllImport(libcef.DllName, EntryPoint = "cef_unregister_internal_web_plugin", CallingConvention = libcef.CEF_CALL)]
        public static extern void unregister_internal_web_plugin(cef_string_t* path);
        
        // CefRegisterWebPluginCrash
        [DllImport(libcef.DllName, EntryPoint = "cef_register_web_plugin_crash", CallingConvention = libcef.CEF_CALL)]
        public static extern void register_web_plugin_crash(cef_string_t* path);
        
        // CefIsWebPluginUnstable
        [DllImport(libcef.DllName, EntryPoint = "cef_is_web_plugin_unstable", CallingConvention = libcef.CEF_CALL)]
        public static extern void is_web_plugin_unstable(cef_string_t* path, cef_web_plugin_unstable_callback_t* callback);
        
        // CefRegisterWidevineCdm
        [DllImport(libcef.DllName, EntryPoint = "cef_register_widevine_cdm", CallingConvention = libcef.CEF_CALL)]
        public static extern void register_widevine_cdm(cef_string_t* path, cef_register_cdm_callback_t* callback);
        
    }
}
