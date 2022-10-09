pipeline {
    agent any
    stages {
        stage('build FrontEnd') { 
            when {
                changelog "upclient.*"
            }
            steps {
                sh '''#!/bin/bash
                cd react-web
                npm run build
                '''
            }
        }
		stage('build BackEnd') { 
            when {
                changelog "upserver.*"
            }
            steps {
                sh '''#!/bin/bash
                cd Pet.Social.Network
                /home/ubuntu/dotnet/dotnet build
                '''
            }
        }
    }
}