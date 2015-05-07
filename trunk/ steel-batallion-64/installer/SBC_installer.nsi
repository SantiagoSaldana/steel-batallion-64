; These are the programs that are needed by SBC Suite.
Section -Prerequisites
	File "vcredist_x86.exe"
	File "vJoy-215-230315.exe"
	File "wdi-simple.exe"
MessageBox MB_YESNO "Install prequisites for Steel Batallion Controller 64 bit driver?" /SD IDYES IDNO endREQ	
	ExecWait "vcredist_x86.exe"
	ExecWait "vJoy-215-230315.exe"
	ExecWait "wdi-simple.exe"
	Goto endREQ
endREQ:	
SectionEnd