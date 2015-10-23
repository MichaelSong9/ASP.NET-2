@rem csc.exe /target:library /out:..\..\bin\ConexaoSQL\OracleServer\obj\release\OracleServer.dll
@rem *.vb /r:System.dll  / r:System.Data.dll   / r:System.Xml.dll  / r:System.Web.dll /r:System.EnterpriseServices.dll /r:System.Data.OleDb.dll  /r:System.Text.dll
@rem pause

gacutil.exe  /i  ..\..\inetpub\wwwroot\bin\ConexaoSQL\OracleServer\obj\release\OracleServer.dll
pause

@rem <!--add assembly="OracleServer, Version=1.0.1922.18627,Culture=neutral,PublicKeyToken=022ba76a688ed214"/-->
