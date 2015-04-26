makecert.exe ^
-n "CN=CARoot" ^
-r ^
-pe ^
-a sha512 ^
-len 4096 ^
-cy authority ^
-sv CARoot.pvk ^
CARoot.cer

pvk2pfx.exe ^
-pvk CARoot.pvk ^
-spc CARoot.cer ^
-pfx CARoot.pfx ^
-po wX39L478

inf2cat /drv:C:\Users\salds_000\Downloads\SBC_driver /os:XP_X86,Vista_X64,Vista_X86,7_X64,7_X86 /v

signtool sign /d "SBC_driver" /du "www.notrealwebsite.com" /f C:\Users\salds_000\Downloads\SBC_driver\CARoot.pfx /p wX39L478 /v C:\Users\salds_000\Downloads\SBC_driver\steel_batallion.cat