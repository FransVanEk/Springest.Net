using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Springest.Net.Models.Trainings
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class response
    {

        private responseMeta metaField;

        private responseTrainings trainingsField;

        /// <remarks/>
        public responseMeta meta
        {
            get
            {
                return this.metaField;
            }
            set
            {
                this.metaField = value;
            }
        }

        /// <remarks/>
        public responseTrainings trainings
        {
            get
            {
                return this.trainingsField;
            }
            set
            {
                this.trainingsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseMeta
    {

        private responseMetaResults resultsField;

        private responseMetaOffset offsetField;

        private responseMetaFilters filtersField;

        /// <remarks/>
        public responseMetaResults results
        {
            get
            {
                return this.resultsField;
            }
            set
            {
                this.resultsField = value;
            }
        }

        /// <remarks/>
        public responseMetaOffset offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }

        /// <remarks/>
        public responseMetaFilters filters
        {
            get
            {
                return this.filtersField;
            }
            set
            {
                this.filtersField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseMetaResults
    {

        private string typeField;

        private ushort valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public ushort Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseMetaOffset
    {

        private string typeField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseMetaFilters
    {

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainings
    {

        private responseTrainingsTraining trainingField;

        private string typeField;

        /// <remarks/>
        public responseTrainingsTraining training
        {
            get
            {
                return this.trainingField;
            }
            set
            {
                this.trainingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTraining
    {

        private responseTrainingsTrainingID idField;

        private string statusField;

        private string modifiedField;

        private responseTrainingsTrainingInstituteid instituteidField;

        private string nameField;

        private string shortnameField;

        private string externalidField;

        private string bookingsemailField;

        private string termsandconditionsurlField;

        private string momentsField;

        private string urlField;

        private string informationrequesturlField;

        private string bookingurlField;

        private string moreinfourlField;

        private string trainingtypeField;

        private decimal priceField;

        private string pricecurrencyField;

        private responseTrainingsTrainingOriginalprice originalpriceField;

        private responseTrainingsTrainingDiscountpercentage discountpercentageField;

        private responseTrainingsTrainingVatrate vatrateField;

        private responseTrainingsTrainingVatamount vatamountField;

        private responseTrainingsTrainingOriginalvatamount originalvatamountField;

        private ushort base_priceField;

        private byte base_vat_amountField;

        private responseTrainingsTrainingAdditionalcosts additionalcostsField;

        private responseTrainingsTrainingAveragerating averageratingField;

        private responseTrainingsTrainingCount countField;

        private responseTrainingsTrainingMaxparticipants maxparticipantsField;

        private responseTrainingsTrainingTotalcoursedays totalcoursedaysField;

        private string timeunitField;

        private responseTrainingsTrainingDuration durationField;

        private string durationunitField;

        private string vatincludedField;

        private responseTrainingsTrainingInstitute instituteField;

        private string descriptionField;

        private responseTrainingsTrainingRegions regionsField;

        private responseTrainingsTrainingLevels levelsField;

        private responseTrainingsTrainingMethods methodsField;

        private responseTrainingsTrainingAssociations associationsField;

        private responseTrainingsTrainingSubjects subjectsField;

        private ushort crohoField;

        private object creboField;

        private ushort soiField;

        private responseTrainingsTrainingStartingdateplaces startingdateplacesField;

        /// <remarks/>
        public responseTrainingsTrainingID id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public string modified
        {
            get
            {
                return this.modifiedField;
            }
            set
            {
                this.modifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("institute-id")]
        public responseTrainingsTrainingInstituteid instituteid
        {
            get
            {
                return this.instituteidField;
            }
            set
            {
                this.instituteidField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("short-name")]
        public string shortname
        {
            get
            {
                return this.shortnameField;
            }
            set
            {
                this.shortnameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("external-id")]
        public string externalid
        {
            get
            {
                return this.externalidField;
            }
            set
            {
                this.externalidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bookings-email")]
        public string bookingsemail
        {
            get
            {
                return this.bookingsemailField;
            }
            set
            {
                this.bookingsemailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("terms-and-conditions-url")]
        public string termsandconditionsurl
        {
            get
            {
                return this.termsandconditionsurlField;
            }
            set
            {
                this.termsandconditionsurlField = value;
            }
        }

        /// <remarks/>
        public string moments
        {
            get
            {
                return this.momentsField;
            }
            set
            {
                this.momentsField = value;
            }
        }

        /// <remarks/>
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("information-request-url")]
        public string informationrequesturl
        {
            get
            {
                return this.informationrequesturlField;
            }
            set
            {
                this.informationrequesturlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("booking-url")]
        public string bookingurl
        {
            get
            {
                return this.bookingurlField;
            }
            set
            {
                this.bookingurlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("more-info-url")]
        public string moreinfourl
        {
            get
            {
                return this.moreinfourlField;
            }
            set
            {
                this.moreinfourlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("training-type")]
        public string trainingtype
        {
            get
            {
                return this.trainingtypeField;
            }
            set
            {
                this.trainingtypeField = value;
            }
        }

        /// <remarks/>
        public decimal price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("price-currency")]
        public string pricecurrency
        {
            get
            {
                return this.pricecurrencyField;
            }
            set
            {
                this.pricecurrencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("original-price")]
        public responseTrainingsTrainingOriginalprice originalprice
        {
            get
            {
                return this.originalpriceField;
            }
            set
            {
                this.originalpriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("discount-percentage")]
        public responseTrainingsTrainingDiscountpercentage discountpercentage
        {
            get
            {
                return this.discountpercentageField;
            }
            set
            {
                this.discountpercentageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vat-rate")]
        public responseTrainingsTrainingVatrate vatrate
        {
            get
            {
                return this.vatrateField;
            }
            set
            {
                this.vatrateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vat-amount")]
        public responseTrainingsTrainingVatamount vatamount
        {
            get
            {
                return this.vatamountField;
            }
            set
            {
                this.vatamountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("original-vat-amount")]
        public responseTrainingsTrainingOriginalvatamount originalvatamount
        {
            get
            {
                return this.originalvatamountField;
            }
            set
            {
                this.originalvatamountField = value;
            }
        }

        /// <remarks/>
        public ushort base_price
        {
            get
            {
                return this.base_priceField;
            }
            set
            {
                this.base_priceField = value;
            }
        }

        /// <remarks/>
        public byte base_vat_amount
        {
            get
            {
                return this.base_vat_amountField;
            }
            set
            {
                this.base_vat_amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("additional-costs")]
        public responseTrainingsTrainingAdditionalcosts additionalcosts
        {
            get
            {
                return this.additionalcostsField;
            }
            set
            {
                this.additionalcostsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("average-rating")]
        public responseTrainingsTrainingAveragerating averagerating
        {
            get
            {
                return this.averageratingField;
            }
            set
            {
                this.averageratingField = value;
            }
        }

        /// <remarks/>
        public responseTrainingsTrainingCount count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("max-participants")]
        public responseTrainingsTrainingMaxparticipants maxparticipants
        {
            get
            {
                return this.maxparticipantsField;
            }
            set
            {
                this.maxparticipantsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("total-course-days")]
        public responseTrainingsTrainingTotalcoursedays totalcoursedays
        {
            get
            {
                return this.totalcoursedaysField;
            }
            set
            {
                this.totalcoursedaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("time-unit")]
        public string timeunit
        {
            get
            {
                return this.timeunitField;
            }
            set
            {
                this.timeunitField = value;
            }
        }

        /// <remarks/>
        public responseTrainingsTrainingDuration duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("duration-unit")]
        public string durationunit
        {
            get
            {
                return this.durationunitField;
            }
            set
            {
                this.durationunitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vat-included")]
        public string vatincluded
        {
            get
            {
                return this.vatincludedField;
            }
            set
            {
                this.vatincludedField = value;
            }
        }

        /// <remarks/>
        public responseTrainingsTrainingInstitute institute
        {
            get
            {
                return this.instituteField;
            }
            set
            {
                this.instituteField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public responseTrainingsTrainingRegions regions
        {
            get
            {
                return this.regionsField;
            }
            set
            {
                this.regionsField = value;
            }
        }

        /// <remarks/>
        public responseTrainingsTrainingLevels levels
        {
            get
            {
                return this.levelsField;
            }
            set
            {
                this.levelsField = value;
            }
        }

        /// <remarks/>
        public responseTrainingsTrainingMethods methods
        {
            get
            {
                return this.methodsField;
            }
            set
            {
                this.methodsField = value;
            }
        }

        /// <remarks/>
        public responseTrainingsTrainingAssociations associations
        {
            get
            {
                return this.associationsField;
            }
            set
            {
                this.associationsField = value;
            }
        }

        /// <remarks/>
        public responseTrainingsTrainingSubjects subjects
        {
            get
            {
                return this.subjectsField;
            }
            set
            {
                this.subjectsField = value;
            }
        }

        /// <remarks/>
        public ushort croho
        {
            get
            {
                return this.crohoField;
            }
            set
            {
                this.crohoField = value;
            }
        }

        /// <remarks/>
        public object crebo
        {
            get
            {
                return this.creboField;
            }
            set
            {
                this.creboField = value;
            }
        }

        /// <remarks/>
        public ushort soi
        {
            get
            {
                return this.soiField;
            }
            set
            {
                this.soiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("starting-dateplaces")]
        public responseTrainingsTrainingStartingdateplaces startingdateplaces
        {
            get
            {
                return this.startingdateplacesField;
            }
            set
            {
                this.startingdateplacesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingID
    {

        private string typeField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingInstituteid
    {

        private string typeField;

        private ushort valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public ushort Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingOriginalprice
    {

        private string typeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingDiscountpercentage
    {

        private string typeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingVatrate
    {

        private bool nilField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool nil
        {
            get
            {
                return this.nilField;
            }
            set
            {
                this.nilField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingVatamount
    {

        private string typeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingOriginalvatamount
    {

        private string typeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingAdditionalcosts
    {

        private responseTrainingsTrainingAdditionalcostsAdditionalcost additionalcostField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("additional-cost")]
        public responseTrainingsTrainingAdditionalcostsAdditionalcost additionalcost
        {
            get
            {
                return this.additionalcostField;
            }
            set
            {
                this.additionalcostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingAdditionalcostsAdditionalcost
    {

        private string nameField;

        private responseTrainingsTrainingAdditionalcostsAdditionalcostAmount amountField;

        private responseTrainingsTrainingAdditionalcostsAdditionalcostVatamount vatamountField;

        private string vatincludedField;

        private responseTrainingsTrainingAdditionalcostsAdditionalcostMandatory mandatoryField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public responseTrainingsTrainingAdditionalcostsAdditionalcostAmount amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vat-amount")]
        public responseTrainingsTrainingAdditionalcostsAdditionalcostVatamount vatamount
        {
            get
            {
                return this.vatamountField;
            }
            set
            {
                this.vatamountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vat-included")]
        public string vatincluded
        {
            get
            {
                return this.vatincludedField;
            }
            set
            {
                this.vatincludedField = value;
            }
        }

        /// <remarks/>
        public responseTrainingsTrainingAdditionalcostsAdditionalcostMandatory mandatory
        {
            get
            {
                return this.mandatoryField;
            }
            set
            {
                this.mandatoryField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingAdditionalcostsAdditionalcostAmount
    {

        private string typeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingAdditionalcostsAdditionalcostVatamount
    {

        private string typeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingAdditionalcostsAdditionalcostMandatory
    {

        private string typeField;

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingAveragerating
    {

        private string typeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingCount
    {

        private string typeField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingMaxparticipants
    {

        private string typeField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingTotalcoursedays
    {

        private string typeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingDuration
    {

        private string typeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingInstitute
    {

        private responseTrainingsTrainingInstituteID idField;

        private string nameField;

        private string shortnameField;

        private string urlField;

        private string logoField;

        private string providerurlField;

        /// <remarks/>
        public responseTrainingsTrainingInstituteID id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("short-name")]
        public string shortname
        {
            get
            {
                return this.shortnameField;
            }
            set
            {
                this.shortnameField = value;
            }
        }

        /// <remarks/>
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        public string logo
        {
            get
            {
                return this.logoField;
            }
            set
            {
                this.logoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("provider-url")]
        public string providerurl
        {
            get
            {
                return this.providerurlField;
            }
            set
            {
                this.providerurlField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingInstituteID
    {

        private string typeField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingRegions
    {

        private responseTrainingsTrainingRegionsRegion regionField;

        private string typeField;

        /// <remarks/>
        public responseTrainingsTrainingRegionsRegion region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingRegionsRegion
    {

        private responseTrainingsTrainingRegionsRegionID idField;

        private string countryField;

        private string shortField;

        private object longField;

        private responseTrainingsTrainingRegionsRegionOrder orderField;

        /// <remarks/>
        public responseTrainingsTrainingRegionsRegionID id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public string @short
        {
            get
            {
                return this.shortField;
            }
            set
            {
                this.shortField = value;
            }
        }

        /// <remarks/>
        public object @long
        {
            get
            {
                return this.longField;
            }
            set
            {
                this.longField = value;
            }
        }

        /// <remarks/>
        public responseTrainingsTrainingRegionsRegionOrder order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingRegionsRegionID
    {

        private string typeField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingRegionsRegionOrder
    {

        private string typeField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingLevels
    {

        private responseTrainingsTrainingLevelsLevel levelField;

        private string typeField;

        /// <remarks/>
        public responseTrainingsTrainingLevelsLevel level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingLevelsLevel
    {

        private responseTrainingsTrainingLevelsLevelID idField;

        private string nameField;

        /// <remarks/>
        public responseTrainingsTrainingLevelsLevelID id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingLevelsLevelID
    {

        private string typeField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingMethods
    {

        private responseTrainingsTrainingMethodsMethod methodField;

        private string typeField;

        /// <remarks/>
        public responseTrainingsTrainingMethodsMethod method
        {
            get
            {
                return this.methodField;
            }
            set
            {
                this.methodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingMethodsMethod
    {

        private responseTrainingsTrainingMethodsMethodID idField;

        private string nameField;

        /// <remarks/>
        public responseTrainingsTrainingMethodsMethodID id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingMethodsMethodID
    {

        private string typeField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingAssociations
    {

        private responseTrainingsTrainingAssociationsAssociation associationField;

        private string typeField;

        /// <remarks/>
        public responseTrainingsTrainingAssociationsAssociation association
        {
            get
            {
                return this.associationField;
            }
            set
            {
                this.associationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingAssociationsAssociation
    {

        private responseTrainingsTrainingAssociationsAssociationID idField;

        private string nameField;

        /// <remarks/>
        public responseTrainingsTrainingAssociationsAssociationID id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingAssociationsAssociationID
    {

        private string typeField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingSubjects
    {

        private responseTrainingsTrainingSubjectsSubject subjectField;

        private string typeField;

        /// <remarks/>
        public responseTrainingsTrainingSubjectsSubject subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingSubjectsSubject
    {

        private responseTrainingsTrainingSubjectsSubjectID idField;

        private responseTrainingsTrainingSubjectsSubjectCategoryid categoryidField;

        private string nameField;

        private string shortnameField;

        private string categoryshortnameField;

        private string urlField;

        private responseTrainingsTrainingSubjectsSubjectCount countField;

        /// <remarks/>
        public responseTrainingsTrainingSubjectsSubjectID id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("category-id")]
        public responseTrainingsTrainingSubjectsSubjectCategoryid categoryid
        {
            get
            {
                return this.categoryidField;
            }
            set
            {
                this.categoryidField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("short-name")]
        public string shortname
        {
            get
            {
                return this.shortnameField;
            }
            set
            {
                this.shortnameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("category-short-name")]
        public string categoryshortname
        {
            get
            {
                return this.categoryshortnameField;
            }
            set
            {
                this.categoryshortnameField = value;
            }
        }

        /// <remarks/>
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        public responseTrainingsTrainingSubjectsSubjectCount count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingSubjectsSubjectID
    {

        private string typeField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingSubjectsSubjectCategoryid
    {

        private string typeField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingSubjectsSubjectCount
    {

        private string typeField;

        private ushort valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public ushort Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingStartingdateplaces
    {

        private responseTrainingsTrainingStartingdateplacesStartingdateplace startingdateplaceField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("starting-dateplace")]
        public responseTrainingsTrainingStartingdateplacesStartingdateplace startingdateplace
        {
            get
            {
                return this.startingdateplaceField;
            }
            set
            {
                this.startingdateplaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingStartingdateplacesStartingdateplace
    {

        private responseTrainingsTrainingStartingdateplacesStartingdateplaceID idField;

        private string placeField;

        private responseTrainingsTrainingStartingdateplacesStartingdateplaceDate dateField;

        private responseTrainingsTrainingStartingdateplacesStartingdateplaceEnddate enddateField;

        private responseTrainingsTrainingStartingdateplacesStartingdateplaceDateismonthonly dateismonthonlyField;

        private responseTrainingsTrainingStartingdateplacesStartingdateplaceEnddateismonthonly enddateismonthonlyField;

        /// <remarks/>
        public responseTrainingsTrainingStartingdateplacesStartingdateplaceID id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string place
        {
            get
            {
                return this.placeField;
            }
            set
            {
                this.placeField = value;
            }
        }

        /// <remarks/>
        public responseTrainingsTrainingStartingdateplacesStartingdateplaceDate date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("end-date")]
        public responseTrainingsTrainingStartingdateplacesStartingdateplaceEnddate enddate
        {
            get
            {
                return this.enddateField;
            }
            set
            {
                this.enddateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("date-is-month-only")]
        public responseTrainingsTrainingStartingdateplacesStartingdateplaceDateismonthonly dateismonthonly
        {
            get
            {
                return this.dateismonthonlyField;
            }
            set
            {
                this.dateismonthonlyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("end-date-is-month-only")]
        public responseTrainingsTrainingStartingdateplacesStartingdateplaceEnddateismonthonly enddateismonthonly
        {
            get
            {
                return this.enddateismonthonlyField;
            }
            set
            {
                this.enddateismonthonlyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingStartingdateplacesStartingdateplaceID
    {

        private string typeField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingStartingdateplacesStartingdateplaceDate
    {

        private string typeField;

        private System.DateTime valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "date")]
        public System.DateTime Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingStartingdateplacesStartingdateplaceEnddate
    {

        private string typeField;

        private System.DateTime valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "date")]
        public System.DateTime Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingStartingdateplacesStartingdateplaceDateismonthonly
    {

        private string typeField;

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseTrainingsTrainingStartingdateplacesStartingdateplaceEnddateismonthonly
    {

        private string typeField;

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }


}
