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

using Amazon.S3;

namespace AwsLabs
{
    internal interface ILabCode
    {
        void CreateBucket(AmazonS3Client s3Client, string bucketName);
        void PutObject(AmazonS3Client s3Client, string bucketName, string sourceFile, string objectKey);
        void ListObjects(AmazonS3Client s3Client, string bucketName);
        void MakeObjectPublic(AmazonS3Client s3Client, string bucketName, string key);
        string GeneratePreSignedUrl(AmazonS3Client s3Client, string bucketName, string key);
    }
}
