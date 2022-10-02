pipeline {
    agent any

    stages {
        stage('Deploy') {
            steps {
                sh '''#!/bin/bash
                cd react-web
                sudo npm run build
                sudo systemctl restart nginx
                '''
            }
        }
    }
}