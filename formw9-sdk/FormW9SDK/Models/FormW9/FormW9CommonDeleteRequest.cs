namespace FormW9SDK.Models.FormW9
{
    public class FormW9CommonDeleteRequest
    {
        public Guid SubmissionId { get; set; }
        public string PayeeRef { get; set; }
        public string Email { get; set; }
        public Guid UserId { get; set; }

    }
}
