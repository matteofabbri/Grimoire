using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Assign_User-Based_Security_GroupsType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Assign_UserBased_Security_GroupsType : INotifyPropertyChanged
	{
		private System_UserObjectType workday_Account_ReferenceField;

		private Assign_UserBased_Security_Groups_DataType assign_UserBased_Security_Groups_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public System_UserObjectType Workday_Account_Reference
		{
			get
			{
				return this.workday_Account_ReferenceField;
			}
			set
			{
				this.workday_Account_ReferenceField = value;
				this.RaisePropertyChanged("Workday_Account_Reference");
			}
		}

		[XmlElement("Assign_User-Based_Security_Groups_Data", Order = 1)]
		public Assign_UserBased_Security_Groups_DataType Assign_UserBased_Security_Groups_Data
		{
			get
			{
				return this.assign_UserBased_Security_Groups_DataField;
			}
			set
			{
				this.assign_UserBased_Security_Groups_DataField = value;
				this.RaisePropertyChanged("Assign_UserBased_Security_Groups_Data");
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
