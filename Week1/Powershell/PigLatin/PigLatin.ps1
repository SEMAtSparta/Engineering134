$vowelsArray = "a","e", "i", "o", "u"
$words = @()
$newWords = @()

#Remove output file if present
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
    #split each line into words
    $words += $line -split " "
    foreach($word in $words)
    {
        do{
            #iteratively test each letter to see if it is a vowel
            $c = $word.Substring(0,1)
            if(Is-Vowel -L $c)
            {
                #cover case where word starts with vowel
                if($prefix.Length -eq 0)
                {
                    $newWords += $prefix + $word + "yay"
                }
                else
                {
                    $newWords += $word + $prefix + "ay"
                }
                #reset prefix for next word
                $prefix = ""
                Break
            }
            $prefix += $c
            $word = $word.Substring(1, $word.Length-1)
        
        }
        while($true)
    }


    foreach($word in $newWords)
    {
        $newLine += $word + " "
    }
    $newLine >> .\output.txt
}

