Log4Net: Fundametals, Practice 2
---


1. Windows service pattern
 a. change to watch the config file
 b. Add a line:
 System.IO.Directory.SetCurrentDirectory("C:/");
 And change to windows service scenario, when the current directory isn't the exe directory - ensure that logging works correctly in this case
2. Using multiple appenders
 a. Add aRollingFileAppender - configure a rolling file appender to put 1KB log in a log subfolder
 Use predefined settings (utf-8, 10 files, preserving .txt extension, no renaming - just adding a higher number)
 b. configure the rolling file appender to show DEBUG, the existing FileAppender appender should log INFO and higher.
3. Using logger for a specific hierarchy level only
Add a separate FileAppender appender for Main.Invoice only that logs DEBUG to log\invoice_log.txt

4. Using context
What context levels are available, which to use for the global context and which for the current values.
Set the operator name context entry for the whole program, remove it at the end.
Set the invoice number context when beginning invoicing, remove it at the end of invoicing - assume that this is valid for a single invoice call only.

5. Working with pattern
In the logger for main.invoice add context information (the operator and invoice number), remove logger information.
Remove seconds from date.

6. One file per run appender configuration
Replace the rolling file appender from (2) with an appender configuration that (a) creates a new file for each run (b) but can roll if the file is too large, e.g. 10MB