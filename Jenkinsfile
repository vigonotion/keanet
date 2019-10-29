pipeline {
    agent { 
        dockerfile {
            filename 'Dockerfile'
            reuseNode true
            args '--entrypoint=\'\''
        }
    }
    stages {
        stage('Test') {
            steps {
                sh 'dotnet --version'
                sh 'dotnet test --logger "trx;LogFileName=results.xml"'
            }
        }
    }
}