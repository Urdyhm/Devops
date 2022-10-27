pipeline {
    agent any

  stages {
        stage('Checkout') {
            node {
                     checkout scm
                }
            steps {
                echo 'Checking..'
            }
        }
    stages {
        stage('Build') {
            steps {
                echo 'Building..'
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}
