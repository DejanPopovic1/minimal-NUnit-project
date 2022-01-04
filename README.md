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
- To run 
