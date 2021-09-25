$ConAdmSec = ConvertTo-SecureString $ConAdm -AsPlainText -Force
if($UO -eq '0')
{
	$dominio = (Get-WmiObject Win32_ComputerSystem).Domain
    $UsuAdmSec = $dominio + '\' + $UsuAdm
}
else
{
	$UsuAdmSec = '.\' + $UsuAdm
}
$Credential = New-Object System.Management.Automation.PSCredential $UsuAdmSec, $ConAdmSec
cd C:\Windows\System32
Start-Process powershell.exe -Credential $credential -windowstyle hidden{ 
	Start-Process  powershell.exe -verb RunAs -windowstyle hidden{
		.(Get-Content -path 'C:\STSetup\path.txt')
	}
}