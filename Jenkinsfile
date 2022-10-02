pipeline {
    agent any

    stages {
        stage('Deploy') {
            steps {
                sh '''#!/bin/bash
                cd react-web
                npm run build
                sudo systemctl restart nginx
                '''
            }
        }
    }
}