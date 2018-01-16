"# .NETCORE2.0 Couchbase JWT SQLServer Hadoop Unit Test CI" 

rd /s /q .git
/.vs/
echo "# .NETCoreHadoop
ConsoleApp" >> README.md
git init
git add README.md
git commit -m "first commit"
git remote add origin https://github.com/tcgdigitaldeepak/.NETCoreHadoopConsoleApp.git
git push -u origin master



$ git commit -m "Something terribly misguided"              (1)
$ git reset HEAD~                                           (2)
<< edit files as necessary >>                               (3)
$ git add ...                                               (4)
$ git commit -c ORIG_HEAD 
