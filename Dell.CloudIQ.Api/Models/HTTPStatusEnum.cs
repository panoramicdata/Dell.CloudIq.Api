namespace Dell.CloudIQ.Api;

/// <summary>
/// Possible HTTP status values of completed or failed jobs.
/// <br/>* 200 - OK - Successful completion, with a response body.
/// <br/>* 201 - Created - Successful completion of a create request (POST to collection resource).
/// <br/>* 202 - Accepted - Job has been started. Response body is a job resource instance. Response status and body are available from job when it completes.
/// <br/>* 204 - No Content - Successful completion, without a response body.
/// <br/>* 206 - Partial Content - Paged response to a collection query.
/// <br/>* 400 - Invalid Request - The request is incorrect. To the extent possible, validate requests up front and use this code. Details in the response body.
/// <br/>* 401 - Unauthorized - The request cannot be authenticated.
/// <br/>* 403 - Forbidden - The request is not allowed for this client.
/// <br/>* 404 - Not Found - The id value in the request URL is not valid.
/// <br/>* 422 - Operation Failed - The request failed during execution.
/// <br/>* 429 - Too Many Requests - This particular client needs to slow down and take it easy. Retry after a delay.
/// <br/>* 500 - Internal Error - This means the product has a bug and customer should contact support.
/// <br/>* 503 - Service Unavailable - The service is temporarily unavailable. Try again later.
/// </summary>
public enum HTTPStatusEnum
{

	@200 = 200,


	@201 = 201,


	@202 = 202,


	@204 = 204,


	@206 = 206,


	@400 = 400,


	@401 = 401,


	@403 = 403,


	@404 = 404,


	@422 = 422,


	@429 = 429,


	@500 = 500,


	@503 = 503,

}
