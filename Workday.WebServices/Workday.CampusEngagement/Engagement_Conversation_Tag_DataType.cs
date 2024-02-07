using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CampusEngagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Engagement_Conversation_Tag_DataType : INotifyPropertyChanged
	{
		private string engagement_Conversation_Tag_NameField;

		private Engagement_Conversation_Tag_CategoryObjectType[] engagement_Conversation_Tag_Category_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Engagement_Conversation_Tag_Name
		{
			get
			{
				return this.engagement_Conversation_Tag_NameField;
			}
			set
			{
				this.engagement_Conversation_Tag_NameField = value;
				this.RaisePropertyChanged("Engagement_Conversation_Tag_Name");
			}
		}

		[XmlElement("Engagement_Conversation_Tag_Category_Reference", Order = 1)]
		public Engagement_Conversation_Tag_CategoryObjectType[] Engagement_Conversation_Tag_Category_Reference
		{
			get
			{
				return this.engagement_Conversation_Tag_Category_ReferenceField;
			}
			set
			{
				this.engagement_Conversation_Tag_Category_ReferenceField = value;
				this.RaisePropertyChanged("Engagement_Conversation_Tag_Category_Reference");
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
