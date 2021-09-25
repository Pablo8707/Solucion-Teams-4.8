if($UO -eq '0')
{
	$CurrentDomain = "LDAP://" + ([ADSI]"").distinguishedName 
    $domain = New-Object System.DirectoryServices.DirectoryEntry($CurrentDomain,$UsuAdm,$ConAdm) 
    if ($domain.name -eq $null) 
    { 
        New-item -path 'C:\STSetup' -name 'BadUsu.txt'
    }
    else
    { 
   
    }
}
else
{
    $ConAdmSec = ConvertTo-SecureString $ConAdm -AsPlainText -Force
    $UsuAdmSec = '.\' + $UsuAdm
    $Credential = New-Object System.Management.Automation.PSCredential $UsuAdmSec, $ConAdmSec
    cd C:\Windows\System32
    try
    {
        Start-Process powershell.exe -Credential $credential -windowstyle hidden{
            Exit
        }
    }
    catch
    {
        New-item -path 'C:\STSetup' -name 'BadUsu.txt'
    }
}

