#!/bin/bash

# Check if PUPPIES_PID exists
if [ ! -f PUPPIES_PID ]; then
  echo "Could not find PUPPIES_PID file to know which process to kill!"
  exit 1
fi

# Read the PID from the file
PID=$(cat PUPPIES_PID)

# Check if the PID is a running process
if ps -p $PID > /dev/null 2>&1; then
  echo "Killing process with PID $PID"
  kill $PID

  # Remove the PIDFILE after successful kill
  rm PUPPIES_PID
else
  echo "No process found with PID $PID"
  exit 1
fi