using System;
namespace StrengthifyNETAPI.Dto
{
    public class SupabaseUserDto
    {
        public Guid id { get; set; }
        public string aud { get; set; }
        public string role { get; set; }
        public string email { get; set; }
        public string email_confirmed_at { get; set; }
        public string phone { get; set; }
        public string last_sign_in_at { get; set; }
    }
    public class SupabaseSignupResponseDto
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string refresh_token { get; set; }
        public SupabaseUserDto user { get; set; }
    }
}

/*
{
    "access_token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJhdWQiOiJhdXRoZW50aWNhdGVkIiwiZXhwIjoxNjUxMzcxNjk2LCJzdWIiOiIxYzlhYWUzZi1iMGIwLTRhMzItODY1Yi00YTM3YzBjMjE5ZjQiLCJlbWFpbCI6Inl1dGl6emxlQHlhaG9vLmNvbSIsInBob25lIjoiIiwiYXBwX21ldGFkYXRhIjp7InByb3ZpZGVyIjoiZW1haWwiLCJwcm92aWRlcnMiOlsiZW1haWwiXX0sInVzZXJfbWV0YWRhdGEiOnt9LCJyb2xlIjoiYXV0aGVudGljYXRlZCJ9.5_KyOlVU0osvmpkFNiGKvfCJI_xBUMf7lQuG100V53w",
    "token_type": "bearer",
    "expires_in": 3600,
    "refresh_token": "6N_q_7q6MpxJP0kUkn2Arg",
    "user": {
        "id": "1c9aae3f-b0b0-4a32-865b-4a37c0c219f4",
        "aud": "authenticated",
        "role": "authenticated",
        "email": "yutizzle@yahoo.com",
        "email_confirmed_at": "2022-05-01T01:21:36.959148251Z",
        "phone": "",
        "last_sign_in_at": "2022-05-01T01:21:36.962915679Z",
        "app_metadata": {
            "provider": "email",
            "providers": [
                "email"
            ]
        },
        "user_metadata": {},
        "identities": [
            {
                "id": "1c9aae3f-b0b0-4a32-865b-4a37c0c219f4",
                "user_id": "1c9aae3f-b0b0-4a32-865b-4a37c0c219f4",
                "identity_data": {
                    "sub": "1c9aae3f-b0b0-4a32-865b-4a37c0c219f4"
                },
                "provider": "email",
                "last_sign_in_at": "2022-05-01T01:21:36.957068308Z",
                "created_at": "2022-05-01T01:21:36.957108Z",
                "updated_at": "2022-05-01T01:21:36.957112Z"
            }
        ],
        "created_at": "2022-05-01T01:21:36.954687Z",
        "updated_at": "2022-05-01T01:21:36.964382Z"
    }
}
*/