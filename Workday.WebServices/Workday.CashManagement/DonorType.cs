using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class DonorType : INotifyPropertyChanged
	{
		private DonorObjectType donor_ReferenceField;

		private Donor_DataType donor_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DonorObjectType Donor_Reference
		{
			get
			{
				return this.donor_ReferenceField;
			}
			set
			{
				this.donor_ReferenceField = value;
				this.RaisePropertyChanged("Donor_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Donor_DataType Donor_Data
		{
			get
			{
				return this.donor_DataField;
			}
			set
			{
				this.donor_DataField = value;
				this.RaisePropertyChanged("Donor_Data");
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
