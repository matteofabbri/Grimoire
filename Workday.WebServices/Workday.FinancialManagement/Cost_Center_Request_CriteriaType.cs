using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Cost_Center_Request_CriteriaType : INotifyPropertyChanged
	{
		private DateTime updated_From_DateField;

		private bool updated_From_DateFieldSpecified;

		private DateTime updated_To_DateField;

		private bool updated_To_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DateTime Updated_From_Date
		{
			get
			{
				return this.updated_From_DateField;
			}
			set
			{
				this.updated_From_DateField = value;
				this.RaisePropertyChanged("Updated_From_Date");
			}
		}

		[XmlIgnore]
		public bool Updated_From_DateSpecified
		{
			get
			{
				return this.updated_From_DateFieldSpecified;
			}
			set
			{
				this.updated_From_DateFieldSpecified = value;
				this.RaisePropertyChanged("Updated_From_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public DateTime Updated_To_Date
		{
			get
			{
				return this.updated_To_DateField;
			}
			set
			{
				this.updated_To_DateField = value;
				this.RaisePropertyChanged("Updated_To_Date");
			}
		}

		[XmlIgnore]
		public bool Updated_To_DateSpecified
		{
			get
			{
				return this.updated_To_DateFieldSpecified;
			}
			set
			{
				this.updated_To_DateFieldSpecified = value;
				this.RaisePropertyChanged("Updated_To_DateSpecified");
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
