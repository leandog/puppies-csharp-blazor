#!/bin/bash

# Run the application in the background
cd build || (echo "Could not find build directory"; exit)

dotnet Puppies.dll &

# Get the PID of the last background process
PID=$!

cd ..

# Write the PID to the file
echo $PID > PUPPIES_PID

# Optional: print a confirmation
echo "Puppies.dll started in background with PID $PID"