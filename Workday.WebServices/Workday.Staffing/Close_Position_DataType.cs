using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Close_Position_DataType : INotifyPropertyChanged
	{
		private Position_RestrictionsObjectType itemField;

		private Close_Position_Event_DataType[] close_Event_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Position_Reference", Order = 0)]
		public Position_RestrictionsObjectType Item
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

		[XmlElement("Close_Event_Data", Order = 1)]
		public Close_Position_Event_DataType[] Close_Event_Data
		{
			get
			{
				return this.close_Event_DataField;
			}
			set
			{
				this.close_Event_DataField = value;
				this.RaisePropertyChanged("Close_Event_Data");
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
