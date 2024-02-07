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
	public class Award_and_Activity_Achievement_DataType : INotifyPropertyChanged
	{
		private string award_and_Activity_IDField;

		private bool remove_Award_and_ActivityField;

		private bool remove_Award_and_ActivityFieldSpecified;

		private Award_and_Activity_TypeObjectType award_and_Activity_Type_ReferenceField;

		private string titleField;

		private string sponsor_IssuerField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private string descriptionField;

		private string uRLField;

		private Position_ElementObjectType related_Position_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Award_and_Activity_ID
		{
			get
			{
				return this.award_and_Activity_IDField;
			}
			set
			{
				this.award_and_Activity_IDField = value;
				this.RaisePropertyChanged("Award_and_Activity_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Remove_Award_and_Activity
		{
			get
			{
				return this.remove_Award_and_ActivityField;
			}
			set
			{
				this.remove_Award_and_ActivityField = value;
				this.RaisePropertyChanged("Remove_Award_and_Activity");
			}
		}

		[XmlIgnore]
		public bool Remove_Award_and_ActivitySpecified
		{
			get
			{
				return this.remove_Award_and_ActivityFieldSpecified;
			}
			set
			{
				this.remove_Award_and_ActivityFieldSpecified = value;
				this.RaisePropertyChanged("Remove_Award_and_ActivitySpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Award_and_Activity_TypeObjectType Award_and_Activity_Type_Reference
		{
			get
			{
				return this.award_and_Activity_Type_ReferenceField;
			}
			set
			{
				this.award_and_Activity_Type_ReferenceField = value;
				this.RaisePropertyChanged("Award_and_Activity_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
				this.RaisePropertyChanged("Title");
			}
		}

		[XmlElement(Order = 4)]
		public string Sponsor_Issuer
		{
			get
			{
				return this.sponsor_IssuerField;
			}
			set
			{
				this.sponsor_IssuerField = value;
				this.RaisePropertyChanged("Sponsor_Issuer");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlIgnore]
		public bool Start_DateSpecified
		{
			get
			{
				return this.start_DateFieldSpecified;
			}
			set
			{
				this.start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
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

		[XmlElement(Order = 7)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 8)]
		public string URL
		{
			get
			{
				return this.uRLField;
			}
			set
			{
				this.uRLField = value;
				this.RaisePropertyChanged("URL");
			}
		}

		[XmlElement(Order = 9)]
		public Position_ElementObjectType Related_Position_Reference
		{
			get
			{
				return this.related_Position_ReferenceField;
			}
			set
			{
				this.related_Position_ReferenceField = value;
				this.RaisePropertyChanged("Related_Position_Reference");
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
