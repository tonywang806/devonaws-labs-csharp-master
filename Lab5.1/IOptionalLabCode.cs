﻿// Copyright 2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License"). You may not 
// use this file except in compliance with the License. A copy of the License 
// is located at
// 
// 	http://aws.amazon.com/apache2.0/
// 
// or in the "LICENSE" file accompanying this file. This file is distributed 
// on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either 
// express or implied. See the License for the specific language governing 
// permissions and limitations under the License.

using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.S3;

namespace AwsLabs
{
    internal interface IOptionalLabCode
    {
        bool IsImageInDynamo(AmazonDynamoDBClient dynamoDbClient, string tableName, string key);
        bool ValidateSchema(TableDescription tableDescription);
        TableDescription GetTableDescription(AmazonDynamoDBClient ddbClient, string tableName);
        string GetTableStatus(AmazonDynamoDBClient ddbClient, string tableName);
        void WaitForStatus(AmazonDynamoDBClient ddbClient, string tableName, string status, DateTime? timeout = null);
        void DeleteTable(AmazonDynamoDBClient ddbClient, string tableName);

        void AddImage(AmazonDynamoDBClient dynamoDbClient, string tableName, AmazonS3Client s3Client, string bucketName,
            string imageKey, string filePath);

        void BuildTable(AmazonDynamoDBClient ddbClient, string tableName);
    }
}
