pipeline {
    environment {
        HOME = '/tmp'
    } 
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
                sh 'cd /app'
                sh 'dotnet test --logger "trx;LogFileName=results.xml"'
            }
        }
    }
}