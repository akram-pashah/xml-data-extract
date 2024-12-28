using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlDataExtract.Models
{
    [XmlRoot("XACTDOC")]
    public class XactDoc
    {
        [XmlElement("XACTNET_INFO")]
        public XactNetInfo XactNetInfo { get; set; }
        [XmlElement("ADM")]
        public Adm Adm { get; set; }
        [XmlElement("CLAIM_INFO")]
        public ClaimInfo ClaimInfo { get; set; }

        [XmlElement("CONTACTS")]
        public Contacts Contacts { get; set; }

        [XmlElement("PROJECT_INFO")]
        public ProjectInfo ProjectInfo { get; set; }
    }
    public class XactNetInfo
    {
        [XmlAttribute("assignmentType")]
        public int AssignmentType { get; set; }

        [XmlAttribute("businessUnit")]
        public string BusinessUnit { get; set; }

        [XmlAttribute("carrierId")]
        public string CarrierId { get; set; }

        [XmlAttribute("createdByEdi")]
        public int CreatedByEdi { get; set; }

        [XmlAttribute("emergency")]
        public int Emergency { get; set; }

        [XmlAttribute("jobSizeCode")]
        public string JobSizeCode { get; set; }

        [XmlAttribute("profileCode")]
        public string ProfileCode { get; set; }

        [XmlAttribute("recipientsXM8UserId")]
        public string RecipientsXM8UserId { get; set; }

        [XmlAttribute("recipientsXNAddress")]
        public string RecipientsXNAddress { get; set; }

        [XmlAttribute("rotationTrade")]
        public string RotationTrade { get; set; }

        [XmlAttribute("senderId")]
        public string SenderId { get; set; }

        [XmlAttribute("sendersXNAddress")]
        public string SendersXNAddress { get; set; }

        [XmlAttribute("transactionId")]
        public string TransactionId { get; set; }

        [XmlAttribute("originalTransactionId")]
        public string OriginalTransactionId { get; set; }

        [XmlAttribute("transactionType")]
        public string TransactionType { get; set; }

        [XmlElement("CONTROL_POINTS")]
        public ControlPoints ControlPoints { get; set; }
    }

    public class ControlPoints
    {
        [XmlElement("CONTROL_POINT")]
        public List<ControlPoint> ControlPointList { get; set; } = new List<ControlPoint>();
    }

    public class ControlPoint
    {
        [XmlAttribute("stamp")]
        public DateTime Stamp { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlAttribute("user")]
        public string User { get; set; }

        [XmlAttribute("userNumber")]
        public string UserNumber { get; set; }

        [XmlElement("NOTES")]
        public string Notes { get; set; }
    }

    public class Adm
    {
        [XmlAttribute("dateOfLoss")]
        public DateTime DateOfLoss { get; set; }

        [XmlAttribute("dateReceived")]
        public DateTime DateReceived { get; set; }

        [XmlElement("COVERAGE_LOSS")]
        public CoverageLoss CoverageLoss { get; set; }
    }

    public class CoverageLoss
    {
        [XmlAttribute("claimNumber")]
        public string ClaimNumber { get; set; }

        [XmlAttribute("dateInitCov")]
        public DateTime DateInitCov { get; set; }

        [XmlAttribute("isCommercial")]
        public int IsCommercial { get; set; }

        [XmlAttribute("policyEnd")]
        public DateTime PolicyEnd { get; set; }

        [XmlAttribute("policyNumber")]
        public string PolicyNumber { get; set; }

        [XmlAttribute("policyStart")]
        public DateTime PolicyStart { get; set; }

        [XmlElement("COVERAGES")]
        public Coverages Coverages { get; set; }

        [XmlElement("DEDUCT_CHOICES")]
        public DeductChoices DeductChoices { get; set; }

        [XmlElement("FORMS")]
        public Forms Forms { get; set; }

        [XmlElement("TOL")]
        public Tol Tol { get; set; }
    }

    public class Coverages
    {
        [XmlElement("COVERAGE")]
        public List<Coverage> CoverageList { get; set; }
    }

    public class Coverage
    {
        [XmlAttribute("applyTo")]
        public int ApplyTo { get; set; }

        [XmlAttribute("coIns")]
        public int CoIns { get; set; }

        [XmlAttribute("covName")]
        public string CovName { get; set; }

        [XmlAttribute("covType")]
        public int CovType { get; set; }

        [XmlAttribute("deductible")]
        public int Deductible { get; set; }

        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("policyLimit")]
        public int PolicyLimit { get; set; }

        [XmlAttribute("reserveAmt")]
        public int ReserveAmt { get; set; }

        [XmlAttribute("sharedDeductibleRefID")]
        public int SharedDeductibleRefID { get; set; }

        [XmlAttribute("sharedLimitRefID")]
        public int SharedLimitRefID { get; set; }

        [XmlElement("ADD_SUBLIMITS")]
        public AddSublimits AddSublimits { get; set; }
    }

    public class AddSublimits
    {
        [XmlElement("ADD_SUBLIMIT")]
        public List<AddSublimit> AddSublimitList { get; set; }
    }

    public class AddSublimit
    {
        [XmlAttribute("aggregate")]
        public int Aggregate { get; set; }

        [XmlAttribute("feature")]
        public string Feature { get; set; }

        [XmlAttribute("single")]
        public string Single { get; set; }

        [XmlAttribute("sublimitid")]
        public int Sublimitid { get; set; }
    }

    public class DeductChoices
    {
        // Add properties as needed
    }

    public class Forms
    {
        [XmlElement("FORM")]
        public List<Form> FormList { get; set; }
    }

    public class Form
    {
        [XmlAttribute("editionDate")]
        public string EditionDate { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }
    }

    public class Tol
    {
        [XmlAttribute("code")]
        public int Code { get; set; }

        [XmlAttribute("desc")]
        public string Desc { get; set; }
    }
    public class ClaimInfo
    {
        [XmlElement("ADMIN_INFO")]
        public AdminInfo AdminInfo { get; set; }

        [XmlElement("ASSIGNMENT_REFERRAL")]
        public AssignmentReferral AssignmentReferral { get; set; }

        [XmlElement("LOSS_INFO")]
        public LossInfo LossInfo { get; set; }
    }

    public class AdminInfo
    {
        [XmlElement("INSURANCE_CLIENT")]
        public InsuranceClient InsuranceClient { get; set; }
    }

    public class InsuranceClient
    {
        [XmlElement("CONTACTMETHODS")]
        public ContactMethods ContactMethods { get; set; }
    }

    public class ContactMethods
    {
        [XmlElement("CONTACT_METHOD")]
        public List<ContactMethod> ContactMethodList { get; set; }
    }

    public class ContactMethod
    {
        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlText]
        public string Value { get; set; }
    }

    public class AssignmentReferral
    {
        [XmlElement("BILLING_ARRANGEMENT")]
        public BillingArrangement BillingArrangement { get; set; }

        [XmlElement("RETURN_PRODUCT_PREFERENCE")]
        public ReturnProductPreference ReturnProductPreference { get; set; }
    }

    public class BillingArrangement
    {
        [XmlElement("BILLING_METHOD")]
        public string BillingMethod { get; set; }

        [XmlElement("BILLING_CONTACT")]
        public string BillingContact { get; set; }
    }

    public class ReturnProductPreference
    {
        [XmlElement("PREFERENCE")]
        public string Preference { get; set; }
    }

    public class LossInfo
    {
        [XmlElement("LOSS_DESCRIPTION")]
        public string LossDescription { get; set; }

        [XmlElement("LOSS_DATE")]
        public DateTime LossDate { get; set; }
    }

    public class Contacts
    {
        [XmlElement("CONTACT")]
        public List<Contact> ContactList { get; set; }
    }

    public class Contact
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlElement("ADDRESSES")]
        public Addresses Addresses { get; set; }

        [XmlElement("CONTACTMETHODS")]
        public ContactMethods ContactMethods { get; set; }
    }

    public class Addresses
    {
        [XmlElement("ADDRESS")]
        public List<Address> AddressList { get; set; }
    }

    public class Address
    {
        [XmlAttribute("city")]
        public string City { get; set; }

        [XmlAttribute("country")]
        public string Country { get; set; }

        [XmlAttribute("postal")]
        public string Postal { get; set; }

        [XmlAttribute("state")]
        public string State { get; set; }

        [XmlAttribute("street")]
        public string Street { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }
    }

    public class ProjectInfo
    {
        [XmlElement("PROJECT_NAME")]
        public string ProjectName { get; set; }

        [XmlElement("PROJECT_DESCRIPTION")]
        public string ProjectDescription { get; set; }
    }
}
