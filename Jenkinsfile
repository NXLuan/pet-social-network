pipeline {
    agent any
    options {
        skipDefaultCheckout true
    }
    stages {
        stage('checkout'){
            steps {
                git branch: 'main', url: 'https://github.com/NXLuan/pet-social-network.git'
            }
        }
        stage('Deploy') { 
            when {
                changelog ".*upserver.*"
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