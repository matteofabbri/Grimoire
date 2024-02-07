using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Payee_NI_Request_CriteriaType : INotifyPropertyChanged
	{
		private object[] itemsField;

		private DateTime effective_As_OfField;

		private bool effective_As_OfFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Company_Reference", typeof(CompanyObjectType), Order = 0), XmlElement("Worker_Reference", typeof(WorkerObjectType), Order = 0)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_As_Of
		{
			get
			{
				return this.effective_As_OfField;
			}
			set
			{
				this.effective_As_OfField = value;
				this.RaisePropertyChanged("Effective_As_Of");
			}
		}

		[XmlIgnore]
		public bool Effective_As_OfSpecified
		{
			get
			{
				return this.effective_As_OfFieldSpecified;
			}
			set
			{
				this.effective_As_OfFieldSpecified = value;
				this.RaisePropertyChanged("Effective_As_OfSpecified");
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
