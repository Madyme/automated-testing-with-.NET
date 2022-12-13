# Continuous Integration with Jenkins tasks

## I can win

1. Clone the project

![IMAGE 2022-12-13 10:04:25](https://user-images.githubusercontent.com/93917197/207231146-e31fde11-9dbc-45cb-9b30-2220d1e21e22.jpg)

2. Launch tests from the project in Java directory with the help of mvn test goal

![run-tests-from-maven-2](https://user-images.githubusercontent.com/93917197/207230390-0a9f6e0e-64e1-4ed8-9238-e7807c6e0357.png)


![IMAGE 2022-12-13 10:01:28](https://user-images.githubusercontent.com/93917197/207230813-6fe10ad4-034a-406d-9034-e075be86f1eb.jpg)

3. Set up build triggers so that the task is performed every 5 minutes

![cron-syntax](https://user-images.githubusercontent.com/93917197/207231313-a66c6555-0a2e-456b-bb37-f2c96411524b.png)


## Bring It On

1. Set up build triggers:
    1. Launch tests not later than 5 minutes after committing in git
    2. Every workday at midnight
   
![cron-syntax-2](https://user-images.githubusercontent.com/93917197/207232111-730ff651-b530-43c8-aa3e-acb4463509f5.png)

2. Publish “Java\target\surefire-reports\com.github.vitalliuss.helloci.AppTest.txt” file as an artifact

![artifact](https://user-images.githubusercontent.com/93917197/207232260-8871406c-8af5-430c-85aa-abca6ec81d09.png)
![artifact-2](https://user-images.githubusercontent.com/93917197/207232352-b532a197-4664-494f-a741-2648d5a31eb6.png)


## Hurt Me Plenty

1. Change the server port for 8081

![portNum- 8081](https://user-images.githubusercontent.com/93917197/207232547-cf54bb9c-915d-4cbd-b3d9-75f1d20ced9d.png)

2. Create a node and set up a server so that the job is performed on a slave-node only

![node](https://user-images.githubusercontent.com/93917197/207232667-58ce8984-e331-46f8-8f76-de397f38d6ab.png)

3. Set up Job Config History and thinBackup

![thinBackup](https://user-images.githubusercontent.com/93917197/207232827-fad54798-545e-4335-a518-15bd3bbb3cb9.png)
![thinBackup-2](https://user-images.githubusercontent.com/93917197/207232900-8f5d51dd-35f2-4062-8d8f-89cc6668cd35.png)

![job-config-history](https://user-images.githubusercontent.com/93917197/207232983-835f5d36-379a-41a3-b3cc-cae825a90622.png)

## Hardcore

1. Create a user and give him permission to read-only mode for Jinkins jobs without the access to edit or change settings

![addUser](https://user-images.githubusercontent.com/93917197/207233220-db726947-b0c8-4025-8eaa-3a21b7b41b3d.png)

2. Create a parametrized job HelloUser which will ask for a user name as a parameter and output "Hello, username!" in the console

![paramJob](https://user-images.githubusercontent.com/93917197/207233327-015c97d2-5a9c-4fd4-9d4f-0b60be9f34f2.png)

![paramJob-2](https://user-images.githubusercontent.com/93917197/207233397-9299c6e3-1005-46c4-95d2-5de39a87e112.png)

3. Mesure unit tests code coverage with the help of the goal  mvn cobertura:cobertura and publish it on the job page as a graphic

![cobertura](https://user-images.githubusercontent.com/93917197/207233470-0aa69434-84f0-4ea1-b07e-be9c0203bc8a.png)

