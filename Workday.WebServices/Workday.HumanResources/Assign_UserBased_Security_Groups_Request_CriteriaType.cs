using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Assign_User-Based_Security_Groups_Request_CriteriaType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Assign_UserBased_Security_Groups_Request_CriteriaType : INotifyPropertyChanged
	{
		private string workday_Account_User_NameField;

		private object[] itemsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Workday_Account_User_Name
		{
			get
			{
				return this.workday_Account_User_NameField;
			}
			set
			{
				this.workday_Account_User_NameField = value;
				this.RaisePropertyChanged("Workday_Account_User_Name");
			}
		}

		[XmlElement("User-Based_Security_Group_Name", typeof(string), Order = 1), XmlElement("User-Based_Security_Group_Reference", typeof(UserBased_Security_GroupObjectType), Order = 1)]
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
