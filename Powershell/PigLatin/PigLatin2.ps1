$vowelsArray = "a","e", "i", "o", "u"
$words = @()
$start = @()

function Is-Vowel {
    param(
    [Parameter (Mandatory = $true)][String]$L
    )
    foreach($vowel in $vowelsArray)
    {
        if($L -eq $vowel)
        {
            Write-Output $TRUE   
            Exit
        }
    }
    Write-Output $FALSE
}

$input = cat -Path .\input.txt
foreach($line in $input)
{ 
    $words += $line -split " "
}
foreach($word in $words)
{
    $c = $word.Substring(0,1)
    $prefix += $c
    $word = $word.Substring(1, $word.Length-1)
    if(Is-Vowel -L $c)
    {
        echo "found a consonsant " $c
    }
}