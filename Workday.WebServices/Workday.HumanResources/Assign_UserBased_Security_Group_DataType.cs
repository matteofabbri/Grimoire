using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Assign_User-Based_Security_Group_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Assign_UserBased_Security_Group_DataType : INotifyPropertyChanged
	{
		private UserBased_Security_GroupObjectType userBased_Security_Group_ReferenceField;

		private System_UserObjectType[] workday_Account_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("User-Based_Security_Group_Reference", Order = 0)]
		public UserBased_Security_GroupObjectType UserBased_Security_Group_Reference
		{
			get
			{
				return this.userBased_Security_Group_ReferenceField;
			}
			set
			{
				this.userBased_Security_Group_ReferenceField = value;
				this.RaisePropertyChanged("UserBased_Security_Group_Reference");
			}
		}

		[XmlElement("Workday_Account_Reference", Order = 1)]
		public System_UserObjectType[] Workday_Account_Reference
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
