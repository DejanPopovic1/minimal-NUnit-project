# **minimal-NUnit-project**

This project demonstrates how to run NUnit tests within a Docker container.

There are two parts to getting NUnit tests to work within a docker container.

Part 1. Pulling the project code
Part 2. Running the required commands to containerise the pulled code

## Part 1
- At a directory of your choosing, run `git clone https://github.com/DejanPopovic1/minimal-NUnit-project.git`

Note the structure required to run NUnit tests. There is a top level directory containing two projects. One project contains the code to be tested. The other project contains the NUnit test code.

## Part 2
- Install docker
(For windows, you can use docker desktop to get the docker command line tools. Download is found at: https://docs.docker.com/desktop/windows/install/)
- In the terminal, change to the root project directory in which the code was cloned to
(This directory has the file ConsoleApp1.sln in it)
- Build an image for the project to be tested. To do this, run `docker build -f ConsoleApp1\Dockerfile --force-rm -t mycodetobetestedimage .`
- Build an image for the NUnit test code. To do this, run `docker build -f TestProject1\Dockerfile --force-rm -t mytestcodeimage .`
- To run the tests, enter into the shell of the mytestcodeimage image. To do this, run `docker run --rm -it --entrypoint /bin/bash mytestcodeimage`
- Once in the shell, run `dotnet test TestProject1.dll`

You should get the followong output in the console:
```
Microsoft (R) Test Execution Command Line Tool Version 16.11.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     1, Skipped:     0, Total:     1, Duration: 5 ms - /app/TestProject1.dll (net5.0)
```
