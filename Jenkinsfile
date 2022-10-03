pipeline {
    agent any
    stages {
        stage('Deploy') { 
            when {
                changelog "upserver.*"
            }
            steps {
                sh '''#!/bin/bash
                cd react-web
                npm run build
                '''
            }
        }
    }
}