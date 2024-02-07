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
	public class Proposed_Supplier_Status_DataType : INotifyPropertyChanged
	{
		private Business_Entity_Status_ValueObjectType status_ReferenceField;

		private Reason_for_Supplier_Status_ChangeObjectType reason_ReferenceField;

		private string reason_DescriptionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Business_Entity_Status_ValueObjectType Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Reason_for_Supplier_Status_ChangeObjectType Reason_Reference
		{
			get
			{
				return this.reason_ReferenceField;
			}
			set
			{
				this.reason_ReferenceField = value;
				this.RaisePropertyChanged("Reason_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Reason_Description
		{
			get
			{
				return this.reason_DescriptionField;
			}
			set
			{
				this.reason_DescriptionField = value;
				this.RaisePropertyChanged("Reason_Description");
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
