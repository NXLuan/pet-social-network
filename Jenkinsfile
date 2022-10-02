pipeline {
    agent any

    stages {
        stage('Deploy') {
            steps {
                sh '''#!/bin/bash
                cd react-web
                npm run build
                systemctl restart nginx
                '''
            }
        }
    }
}