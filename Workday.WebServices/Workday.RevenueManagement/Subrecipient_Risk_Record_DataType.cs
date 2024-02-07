using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Subrecipient_Risk_Record_DataType : INotifyPropertyChanged
	{
		private string subrecipient_Risk_Record_IDField;

		private Subrecipient_AbstractObjectType subrecipient_ReferenceField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private DateTime evaluation_DateField;

		private bool evaluation_DateFieldSpecified;

		private Risk_Evaluation_LevelObjectType risk_Level_ReferenceField;

		private string commentsField;

		private string uRLField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Subrecipient_Risk_Record_ID
		{
			get
			{
				return this.subrecipient_Risk_Record_IDField;
			}
			set
			{
				this.subrecipient_Risk_Record_IDField = value;
				this.RaisePropertyChanged("Subrecipient_Risk_Record_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Subrecipient_AbstractObjectType Subrecipient_Reference
		{
			get
			{
				return this.subrecipient_ReferenceField;
			}
			set
			{
				this.subrecipient_ReferenceField = value;
				this.RaisePropertyChanged("Subrecipient_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
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

		[XmlElement(DataType = "date", Order = 3)]
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

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Evaluation_Date
		{
			get
			{
				return this.evaluation_DateField;
			}
			set
			{
				this.evaluation_DateField = value;
				this.RaisePropertyChanged("Evaluation_Date");
			}
		}

		[XmlIgnore]
		public bool Evaluation_DateSpecified
		{
			get
			{
				return this.evaluation_DateFieldSpecified;
			}
			set
			{
				this.evaluation_DateFieldSpecified = value;
				this.RaisePropertyChanged("Evaluation_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Risk_Evaluation_LevelObjectType Risk_Level_Reference
		{
			get
			{
				return this.risk_Level_ReferenceField;
			}
			set
			{
				this.risk_Level_ReferenceField = value;
				this.RaisePropertyChanged("Risk_Level_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string Comments
		{
			get
			{
				return this.commentsField;
			}
			set
			{
				this.commentsField = value;
				this.RaisePropertyChanged("Comments");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement("Attachment_Data", Order = 8)]
		public Financials_Attachment_DataType[] Attachment_Data
		{
			get
			{
				return this.attachment_DataField;
			}
			set
			{
				this.attachment_DataField = value;
				this.RaisePropertyChanged("Attachment_Data");
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
