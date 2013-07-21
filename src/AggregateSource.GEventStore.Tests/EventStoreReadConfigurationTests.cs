﻿using System;
using AggregateSource.GEventStore.Builders;
using AggregateSource.GEventStore.Stubs;
using NUnit.Framework;

namespace AggregateSource.GEventStore {
  [TestFixture]
  public class EventStoreReadConfigurationTests {
    EventStoreReadConfigurationBuilder _sutBuilder;

    [SetUp]
    public void SetUp() {
      _sutBuilder = EventStoreReadConfigurationBuilder.Default;
    }

    [Test]
    public void DeserializerCannotBeNull() {
      Assert.Throws<ArgumentNullException>(() => _sutBuilder.UsingDeserializer(null).Build());
    }

    [Test]
    public void StreamNameResolverCannotBeNull() {
      Assert.Throws<ArgumentNullException>(() => _sutBuilder.UsingStreamNameResolver(null).Build());
    }

    [Test]
    public void StreamUserCredentialsResolverCannotBeNull() {
      Assert.Throws<ArgumentNullException>(() => _sutBuilder.UsingStreamUserCredentialsResolver(null).Build());
    }

    [Test]
    public void UsingConstructorReturnsInstanceWithExpectedProperties() {
      var sut = _sutBuilder.Build();

      Assert.That(sut.SliceSize, Is.EqualTo(new SliceSize(1)));
      Assert.That(sut.Deserializer, Is.SameAs(StubbedEventDeserializer.Instance));
      Assert.That(sut.StreamNameResolver, Is.SameAs(StubbedStreamNameResolver.Instance));
      Assert.That(sut.StreamUserCredentialsResolver, Is.SameAs(StubbedStreamUserCredentialsResolver.Instance));
    }
  }
}
