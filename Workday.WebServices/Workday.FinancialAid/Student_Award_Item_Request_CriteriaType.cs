using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Award_Item_Request_CriteriaType : INotifyPropertyChanged
	{
		private DateTime effective_as_of_DateField;

		private bool effective_as_of_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Effective_as_of_Date
		{
			get
			{
				return this.effective_as_of_DateField;
			}
			set
			{
				this.effective_as_of_DateField = value;
				this.RaisePropertyChanged("Effective_as_of_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_as_of_DateSpecified
		{
			get
			{
				return this.effective_as_of_DateFieldSpecified;
			}
			set
			{
				this.effective_as_of_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_as_of_DateSpecified");
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
