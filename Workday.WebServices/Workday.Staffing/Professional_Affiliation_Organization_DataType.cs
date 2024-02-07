using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Professional_Affiliation_Organization_DataType : INotifyPropertyChanged
	{
		private string professional_Affiliation_IDField;

		private bool remove_Professional_AffiliationField;

		private bool remove_Professional_AffiliationFieldSpecified;

		private Professional_Affiliation_ReferenceObjectType professional_Affiliation_ReferenceField;

		private string professional_AffiliationField;

		private Professional_Affiliation_Type__All_ObjectType professional_Affiliation_Type_ReferenceField;

		private string affiliationField;

		private Professional_Affiliation_Relationship_TypeObjectType professional_Affiliation_Relationship_Type_ReferenceField;

		private DateTime begin_DateField;

		private bool begin_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Professional_Affiliation_ID
		{
			get
			{
				return this.professional_Affiliation_IDField;
			}
			set
			{
				this.professional_Affiliation_IDField = value;
				this.RaisePropertyChanged("Professional_Affiliation_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Remove_Professional_Affiliation
		{
			get
			{
				return this.remove_Professional_AffiliationField;
			}
			set
			{
				this.remove_Professional_AffiliationField = value;
				this.RaisePropertyChanged("Remove_Professional_Affiliation");
			}
		}

		[XmlIgnore]
		public bool Remove_Professional_AffiliationSpecified
		{
			get
			{
				return this.remove_Professional_AffiliationFieldSpecified;
			}
			set
			{
				this.remove_Professional_AffiliationFieldSpecified = value;
				this.RaisePropertyChanged("Remove_Professional_AffiliationSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Professional_Affiliation_ReferenceObjectType Professional_Affiliation_Reference
		{
			get
			{
				return this.professional_Affiliation_ReferenceField;
			}
			set
			{
				this.professional_Affiliation_ReferenceField = value;
				this.RaisePropertyChanged("Professional_Affiliation_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Professional_Affiliation
		{
			get
			{
				return this.professional_AffiliationField;
			}
			set
			{
				this.professional_AffiliationField = value;
				this.RaisePropertyChanged("Professional_Affiliation");
			}
		}

		[XmlElement(Order = 4)]
		public Professional_Affiliation_Type__All_ObjectType Professional_Affiliation_Type_Reference
		{
			get
			{
				return this.professional_Affiliation_Type_ReferenceField;
			}
			set
			{
				this.professional_Affiliation_Type_ReferenceField = value;
				this.RaisePropertyChanged("Professional_Affiliation_Type_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Affiliation
		{
			get
			{
				return this.affiliationField;
			}
			set
			{
				this.affiliationField = value;
				this.RaisePropertyChanged("Affiliation");
			}
		}

		[XmlElement(Order = 6)]
		public Professional_Affiliation_Relationship_TypeObjectType Professional_Affiliation_Relationship_Type_Reference
		{
			get
			{
				return this.professional_Affiliation_Relationship_Type_ReferenceField;
			}
			set
			{
				this.professional_Affiliation_Relationship_Type_ReferenceField = value;
				this.RaisePropertyChanged("Professional_Affiliation_Relationship_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Begin_Date
		{
			get
			{
				return this.begin_DateField;
			}
			set
			{
				this.begin_DateField = value;
				this.RaisePropertyChanged("Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Begin_DateSpecified
		{
			get
			{
				return this.begin_DateFieldSpecified;
			}
			set
			{
				this.begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Begin_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
