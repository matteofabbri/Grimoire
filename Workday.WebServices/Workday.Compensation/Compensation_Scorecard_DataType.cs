using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Compensation_Scorecard_DataType : INotifyPropertyChanged
	{
		private string idField;

		private DateTime effective_DateField;

		private string scorecard_NameField;

		private string scorecard_DescriptionField;

		private Performance_Criteria_DataType[] scorecard_Goals_DataField;

		private Scorecard_Profile_DataType[] scorecard_Profile_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlElement(Order = 2)]
		public string Scorecard_Name
		{
			get
			{
				return this.scorecard_NameField;
			}
			set
			{
				this.scorecard_NameField = value;
				this.RaisePropertyChanged("Scorecard_Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Scorecard_Description
		{
			get
			{
				return this.scorecard_DescriptionField;
			}
			set
			{
				this.scorecard_DescriptionField = value;
				this.RaisePropertyChanged("Scorecard_Description");
			}
		}

		[XmlElement("Scorecard_Goals_Data", Order = 4)]
		public Performance_Criteria_DataType[] Scorecard_Goals_Data
		{
			get
			{
				return this.scorecard_Goals_DataField;
			}
			set
			{
				this.scorecard_Goals_DataField = value;
				this.RaisePropertyChanged("Scorecard_Goals_Data");
			}
		}

		[XmlElement("Scorecard_Profile_Data", Order = 5)]
		public Scorecard_Profile_DataType[] Scorecard_Profile_Data
		{
			get
			{
				return this.scorecard_Profile_DataField;
			}
			set
			{
				this.scorecard_Profile_DataField = value;
				this.RaisePropertyChanged("Scorecard_Profile_Data");
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
