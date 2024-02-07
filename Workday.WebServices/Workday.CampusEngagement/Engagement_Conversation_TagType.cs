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
	public class Engagement_Conversation_TagType : INotifyPropertyChanged
	{
		private Engagement_Conversation_TagObjectType engagement_Conversation_Tag_ReferenceField;

		private Engagement_Conversation_Tag_DataType[] engagement_Conversation_Tag_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Engagement_Conversation_TagObjectType Engagement_Conversation_Tag_Reference
		{
			get
			{
				return this.engagement_Conversation_Tag_ReferenceField;
			}
			set
			{
				this.engagement_Conversation_Tag_ReferenceField = value;
				this.RaisePropertyChanged("Engagement_Conversation_Tag_Reference");
			}
		}

		[XmlElement("Engagement_Conversation_Tag_Data", Order = 1)]
		public Engagement_Conversation_Tag_DataType[] Engagement_Conversation_Tag_Data
		{
			get
			{
				return this.engagement_Conversation_Tag_DataField;
			}
			set
			{
				this.engagement_Conversation_Tag_DataField = value;
				this.RaisePropertyChanged("Engagement_Conversation_Tag_Data");
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
