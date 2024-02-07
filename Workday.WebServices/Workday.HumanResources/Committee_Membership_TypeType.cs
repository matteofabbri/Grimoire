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
	public class Committee_Membership_TypeType : INotifyPropertyChanged
	{
		private Committee_Membership_TypeObjectType committee_Membership_Type_ReferenceField;

		private Committee_Membership_Type_DataType[] committee_Membership_Type_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Committee_Membership_TypeObjectType Committee_Membership_Type_Reference
		{
			get
			{
				return this.committee_Membership_Type_ReferenceField;
			}
			set
			{
				this.committee_Membership_Type_ReferenceField = value;
				this.RaisePropertyChanged("Committee_Membership_Type_Reference");
			}
		}

		[XmlElement("Committee_Membership_Type_Data", Order = 1)]
		public Committee_Membership_Type_DataType[] Committee_Membership_Type_Data
		{
			get
			{
				return this.committee_Membership_Type_DataField;
			}
			set
			{
				this.committee_Membership_Type_DataField = value;
				this.RaisePropertyChanged("Committee_Membership_Type_Data");
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
