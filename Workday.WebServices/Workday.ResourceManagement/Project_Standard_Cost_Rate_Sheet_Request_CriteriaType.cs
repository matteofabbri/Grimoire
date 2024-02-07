using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Project_Standard_Cost_Rate_Sheet_Request_CriteriaType : INotifyPropertyChanged
	{
		private CurrencyObjectType project_Rate_Sheet_Currency_ReferenceField;

		private DateTime project_Rate_Sheet_Effective_DateField;

		private bool project_Rate_Sheet_Effective_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CurrencyObjectType Project_Rate_Sheet_Currency_Reference
		{
			get
			{
				return this.project_Rate_Sheet_Currency_ReferenceField;
			}
			set
			{
				this.project_Rate_Sheet_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Project_Rate_Sheet_Currency_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Project_Rate_Sheet_Effective_Date
		{
			get
			{
				return this.project_Rate_Sheet_Effective_DateField;
			}
			set
			{
				this.project_Rate_Sheet_Effective_DateField = value;
				this.RaisePropertyChanged("Project_Rate_Sheet_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Project_Rate_Sheet_Effective_DateSpecified
		{
			get
			{
				return this.project_Rate_Sheet_Effective_DateFieldSpecified;
			}
			set
			{
				this.project_Rate_Sheet_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Project_Rate_Sheet_Effective_DateSpecified");
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
