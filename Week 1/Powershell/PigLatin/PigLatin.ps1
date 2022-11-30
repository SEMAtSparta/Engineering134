$vowelsArray = "a","e", "i", "o", "u"
$words = @()
$newWords = @()
$start = @()

if(Get-Item -Path .\output.txt -ErrorAction Ignore)
{
    Remove-Item '.\output.txt'
}

function Is-Vowel {
    param(
    [Parameter (Mandatory = $true)][String]$L
    )
    foreach($vowel in $vowelsArray)
    {
        if($L -eq $vowel)
        {
            Write-Output $TRUE   
            Break
        }
    }
    Write-Output $FALSE
}

$input = cat -Path .\input.txt
foreach($line in $input)
{ 
    $words += $line -split " "
    foreach($word in $words)
    {
        $break = $true
        do{
            $c = $word.Substring(0,1)
            if(Is-Vowel -L $c)
            {
                if($prefix.Length -eq 0)
                {
                    $newWords += $prefix + $word + "yay"
                }
                else
                {
                    $newWords += $word + $prefix + "ay"
                }
                $prefix = ""
                Break
            }
            $prefix += $c
            $word = $word.Substring(1, $word.Length-1)
        
        }
        while($break)
    }


    foreach($word in $newWords)
    {
        $newLine += $word + " "
    }
    $newLine >> .\output.txt
}

