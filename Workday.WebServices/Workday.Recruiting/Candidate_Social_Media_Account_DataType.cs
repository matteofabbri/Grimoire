using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Candidate_Social_Media_Account_DataType : INotifyPropertyChanged
	{
		private Social_Network_Meta_TypeObjectType social_Network_Type_ReferenceField;

		private string itemField;

		private ItemChoiceType5 itemElementNameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Social_Network_Meta_TypeObjectType Social_Network_Type_Reference
		{
			get
			{
				return this.social_Network_Type_ReferenceField;
			}
			set
			{
				this.social_Network_Type_ReferenceField = value;
				this.RaisePropertyChanged("Social_Network_Type_Reference");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Social_Network_Account_URL", typeof(string), Order = 1), XmlElement("Social_Network_Account_User_Name", typeof(string), Order = 1)]
		public string Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 2), XmlIgnore]
		public ItemChoiceType5 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
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
