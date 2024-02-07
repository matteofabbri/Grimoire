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
	public class Academic_Unit_Request_CriteriaType : INotifyPropertyChanged
	{
		private string academic_Unit_NameField;

		private DateTime effective_As_Of_DateField;

		private bool effective_As_Of_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Academic_Unit_Name
		{
			get
			{
				return this.academic_Unit_NameField;
			}
			set
			{
				this.academic_Unit_NameField = value;
				this.RaisePropertyChanged("Academic_Unit_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_As_Of_Date
		{
			get
			{
				return this.effective_As_Of_DateField;
			}
			set
			{
				this.effective_As_Of_DateField = value;
				this.RaisePropertyChanged("Effective_As_Of_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_As_Of_DateSpecified
		{
			get
			{
				return this.effective_As_Of_DateFieldSpecified;
			}
			set
			{
				this.effective_As_Of_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_As_Of_DateSpecified");
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
