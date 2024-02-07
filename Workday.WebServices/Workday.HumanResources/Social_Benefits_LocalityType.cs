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
	public class Social_Benefits_LocalityType : INotifyPropertyChanged
	{
		private Social_Benefits_LocalityObjectType social_Benefits_Locality_ReferenceField;

		private Social_Benefits_Locality_DataType social_Benefits_Locality_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Social_Benefits_LocalityObjectType Social_Benefits_Locality_Reference
		{
			get
			{
				return this.social_Benefits_Locality_ReferenceField;
			}
			set
			{
				this.social_Benefits_Locality_ReferenceField = value;
				this.RaisePropertyChanged("Social_Benefits_Locality_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Social_Benefits_Locality_DataType Social_Benefits_Locality_Data
		{
			get
			{
				return this.social_Benefits_Locality_DataField;
			}
			set
			{
				this.social_Benefits_Locality_DataField = value;
				this.RaisePropertyChanged("Social_Benefits_Locality_Data");
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
