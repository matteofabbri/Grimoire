using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Get_Assign_User-Based_Security_Group_RequestType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Get_Assign_UserBased_Security_Group_RequestType : INotifyPropertyChanged
	{
		private object[] itemsField;

		private Response_FilterType[] response_FilterField;

		private UserBased_Security_Group_Reference_Only_Response_GroupType[] response_GroupField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Request_Criteria", typeof(UserBased_Security_Group_Request_CriteriaType), Order = 0), XmlElement("Request_References", typeof(UserBased_Security_Group_Request_ReferencesType), Order = 0)]
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

		[XmlElement("Response_Filter", Order = 1)]
		public Response_FilterType[] Response_Filter
		{
			get
			{
				return this.response_FilterField;
			}
			set
			{
				this.response_FilterField = value;
				this.RaisePropertyChanged("Response_Filter");
			}
		}

		[XmlElement("Response_Group", Order = 2)]
		public UserBased_Security_Group_Reference_Only_Response_GroupType[] Response_Group
		{
			get
			{
				return this.response_GroupField;
			}
			set
			{
				this.response_GroupField = value;
				this.RaisePropertyChanged("Response_Group");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
