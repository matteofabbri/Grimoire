using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Former_Worker_Request_CriteriaType : INotifyPropertyChanged
	{
		private DateTime updated_From_MomentField;

		private bool updated_From_MomentFieldSpecified;

		private DateTime update_To_MomentField;

		private bool update_To_MomentFieldSpecified;

		private DateTime terminated_From_DateField;

		private bool terminated_From_DateFieldSpecified;

		private DateTime terminated_To_DateField;

		private bool terminated_To_DateFieldSpecified;

		private Worker_by_National_ID_Request_CriteriaType[] national_ID_Criteria_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DateTime Updated_From_Moment
		{
			get
			{
				return this.updated_From_MomentField;
			}
			set
			{
				this.updated_From_MomentField = value;
				this.RaisePropertyChanged("Updated_From_Moment");
			}
		}

		[XmlIgnore]
		public bool Updated_From_MomentSpecified
		{
			get
			{
				return this.updated_From_MomentFieldSpecified;
			}
			set
			{
				this.updated_From_MomentFieldSpecified = value;
				this.RaisePropertyChanged("Updated_From_MomentSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public DateTime Update_To_Moment
		{
			get
			{
				return this.update_To_MomentField;
			}
			set
			{
				this.update_To_MomentField = value;
				this.RaisePropertyChanged("Update_To_Moment");
			}
		}

		[XmlIgnore]
		public bool Update_To_MomentSpecified
		{
			get
			{
				return this.update_To_MomentFieldSpecified;
			}
			set
			{
				this.update_To_MomentFieldSpecified = value;
				this.RaisePropertyChanged("Update_To_MomentSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Terminated_From_Date
		{
			get
			{
				return this.terminated_From_DateField;
			}
			set
			{
				this.terminated_From_DateField = value;
				this.RaisePropertyChanged("Terminated_From_Date");
			}
		}

		[XmlIgnore]
		public bool Terminated_From_DateSpecified
		{
			get
			{
				return this.terminated_From_DateFieldSpecified;
			}
			set
			{
				this.terminated_From_DateFieldSpecified = value;
				this.RaisePropertyChanged("Terminated_From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Terminated_To_Date
		{
			get
			{
				return this.terminated_To_DateField;
			}
			set
			{
				this.terminated_To_DateField = value;
				this.RaisePropertyChanged("Terminated_To_Date");
			}
		}

		[XmlIgnore]
		public bool Terminated_To_DateSpecified
		{
			get
			{
				return this.terminated_To_DateFieldSpecified;
			}
			set
			{
				this.terminated_To_DateFieldSpecified = value;
				this.RaisePropertyChanged("Terminated_To_DateSpecified");
			}
		}

		[XmlElement("National_ID_Criteria_Data", Order = 4)]
		public Worker_by_National_ID_Request_CriteriaType[] National_ID_Criteria_Data
		{
			get
			{
				return this.national_ID_Criteria_DataField;
			}
			set
			{
				this.national_ID_Criteria_DataField = value;
				this.RaisePropertyChanged("National_ID_Criteria_Data");
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
