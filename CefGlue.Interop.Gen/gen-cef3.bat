@echo off
python -B cefglue_interop_gen.py --cpp-header-dir include --cefglue-dir ..\CefGlue\ --no-backup
pause
