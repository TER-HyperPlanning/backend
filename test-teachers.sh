#!/bin/bash

BASE_URL="http://localhost:5075/api/teachers"

echo "=========================================="
echo "Testing Teacher CRUD Operations"
echo "=========================================="

# Test 1: CREATE
echo -e "\n[TEST 1] Creating a new teacher..."
curl -X POST "$BASE_URL" \
  -H "Content-Type: application/json" \
  -d '{
    "email": "john.doe@university.edu",
    "password": "TeacherPass123!",
    "firstName": "John",
    "lastName": "Doe",
    "phone": "+33612345678",
    "matricule": "T002",
    "titleId": null
  }' | jq '.'

# Test 2: GET ALL
echo -e "\n[TEST 2] Getting all teachers..."
curl -X GET "$BASE_URL" \
  -H "Content-Type: application/json" | jq '.'

# Test 3: GET BY ID (using the existing teacher ID from database)
echo -e "\n[TEST 3] Getting teacher by ID..."
curl -X GET "$BASE_URL/455c6918-8f55-8171-e3b6-573e17977cfc" \
  -H "Content-Type: application/json" | jq '.'

echo -e "\n=========================================="
echo "Tests completed!"
echo "=========================================="