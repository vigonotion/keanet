pipeline {
    agent { 
        dockerfile {
            filename 'Dockerfile'
            reuseNode true    
        }
    }
    stages {
        stage('Test') {
            steps {
                sh 'dotnet --version'
            }
        }
    }
}