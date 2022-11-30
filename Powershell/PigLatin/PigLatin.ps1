$vowelsArray = "a","e", "i", "o", "u"
$words = @()

$input = Get-Content -Path .\input.txt
foreach($line in $input)
{
    do{
        if($line.IndexOf(" ") -lt 0){
            if($line.IndexOf(".") -lt 0){
                words += $line
                $line = ""
            }
            else{
                $i = $line.IndexOf(".")
            }
        }
        else{
            if($line.IndexOf(" ") -lt $line.IndexOf(".")){
                $i = $line.IndexOf(" ")
            }
            else{
                $i = $line.IndexOf(".")
            }
        }
        if(-not($line  -eq ""))
        {
            words += $line.Substring(0, $i)
            $line = $line.Substring($i, $line.Length - $i)
        }
    }
    while(-not($line  -eq ""))

    echo $words

}